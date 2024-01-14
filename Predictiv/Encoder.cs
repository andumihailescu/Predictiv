using Bit_Reader_Writer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictiv
{
    internal class Encoder
    {
        private int[,] imageMatrix = new int[256, 256];
        private BitReader bitReader;
        private BitWriter bitWriter;
        private string outputFilePath;
        private long fileLength;
        private long numberOfRemainingBytes;
        private uint[] imageHeader = new uint[1078];

        int[,] predictionMatrix = new int[256, 256];
        int[,] errorMatrix = new int[256, 256];

        uint selectedPredictor = 0;

        public Encoder(Bitmap bmp, string inputFilePath)
        {
            bitReader = new BitReader(inputFilePath);
            outputFilePath = inputFilePath;
            fileLength = bitReader.GetFileLengthInBytes();

            for (int i = 0; i < 1078; i++)
            {
                imageHeader[i] = bitReader.ReadNBits(8);
            }
            numberOfRemainingBytes = fileLength - 1078;
            int row = 255; int column = 0;
            while (numberOfRemainingBytes > 0)
            {
                imageMatrix[row, column] = (int)bitReader.ReadNBits(8);
                column++;
                if (column == 256)
                {
                    column = 0;
                    row--;
                }
                numberOfRemainingBytes--;
            }

            bitReader.CloseFile();
        }

        public int[,] GetImageMatrix()
        {
            return imageMatrix;
        }

        public void SetSelectedPredictor(uint predictorNumber)
        {
            selectedPredictor = predictorNumber;
        }

        public int[,] GetErrorMatrix()
        {
            return errorMatrix;
        }

        public void CalculatePredictionMatrix()
        {
            if (selectedPredictor == 0)
            {
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        predictionMatrix[i, j] = 128;
                    }
                }
            }
            else
            {
                predictionMatrix[0, 0] = 128;

                for (int i = 1; i < 256; i++)
                {
                    predictionMatrix[0, i] = imageMatrix[0, i - 1];
                    predictionMatrix[i, 0] = imageMatrix[i - 1, 0];
                }

                switch (selectedPredictor)
                {
                    case 1: //A
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1];
                                predictionMatrix[i, j] = A;
                            }
                        }
                        break;
                    case 2: //B
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int B = imageMatrix[i - 1, j];
                                predictionMatrix[i, j] = B;
                            }
                        }
                        break;
                    case 3: //C
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int C = imageMatrix[i - 1, j - 1];
                                predictionMatrix[i, j] = C;
                            }
                        }
                        break;
                    case 4: //A + B - C
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1]; int B = imageMatrix[i - 1, j]; int C = imageMatrix[i - 1, j - 1];
                                predictionMatrix[i, j] = A + B - C;
                            }
                        }
                        break;
                    case 5: //A + (B - C) / 2
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1]; int B = imageMatrix[i - 1, j]; int C = imageMatrix[i - 1, j - 1];
                                predictionMatrix[i, j] = A + (B - C) / 2;
                            }
                        }
                        break;
                    case 6: //B + (A - C) / 2
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1]; int B = imageMatrix[i - 1, j]; int C = imageMatrix[i - 1, j - 1];
                                predictionMatrix[i, j] = B + (A - C) / 2;
                            }
                        }
                        break;
                    case 7: //(A + B) / 2
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1]; int B = imageMatrix[i - 1, j];
                                predictionMatrix[i, j] = (A + B) / 2;
                            }
                        }
                        break;
                    case 8:
                        for (int i = 1; i < 256; i++)
                        {
                            for (int j = 1; j < 256; j++)
                            {
                                int A = imageMatrix[i, j - 1]; int B = imageMatrix[i - 1, j]; int C = imageMatrix[i - 1, j - 1];
                                int minab = 0; int maxab = 0;
                                if (A >= B)
                                {
                                    minab = B;
                                    maxab = A;
                                }
                                else
                                {
                                    maxab = B;
                                    minab = A;
                                }
                                if (C >= maxab)
                                {
                                    predictionMatrix[i, j] = minab;
                                }
                                else if (C <= minab)
                                {
                                    predictionMatrix[i, j] = maxab;
                                }
                                else
                                {
                                    predictionMatrix[i, j] = A + B - C;
                                }
                            }
                        }
                        break;
                }

            }
            
            

            
        }

        public void CalculateErrorMatrix()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    errorMatrix[i, j] = imageMatrix[i, j] - predictionMatrix[i, j];
                }
            }
        }

        public void EncodeImage()
        {
            outputFilePath = outputFilePath + selectedPredictor + ".pre";
            bitWriter = new BitWriter(outputFilePath);

            for (int i = 0; i < 1078; i++)
            {
                bitWriter.WriteNBits(8, imageHeader[i]);
            }
            
            bitWriter.WriteNBits(4, selectedPredictor);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0;j < 256; j++)
                {
                    if (errorMatrix[i, j] < 0)
                    {
                        bitWriter.WriteNBits(1, 1);
                        bitWriter.WriteNBits(8, (uint)((errorMatrix[i, j] * -1)));
                    }
                    else
                    {
                        bitWriter.WriteNBits(9, (uint)errorMatrix[i, j]);
                    }
                }
            }

            uint numberOfFinalBits = (4 + 256 * 256 * 9) % 8;
            bitWriter.WriteNBits(numberOfFinalBits, 0);

            bitWriter.CloseFile();
        }

    }

    
            
}
