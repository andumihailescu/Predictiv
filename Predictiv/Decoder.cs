using Bit_Reader_Writer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictiv
{
    internal class Decoder
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

        public Decoder(string inputFilePath)
        {
            bitReader = new BitReader(inputFilePath);
            outputFilePath = inputFilePath;
            fileLength = bitReader.GetFileLengthInBytes();

            for (int i = 0; i < 1078; i++)
            {
                imageHeader[i] = bitReader.ReadNBits(8);
            }
            numberOfRemainingBytes = fileLength - 1078;
            long numberOfRemainingBits = numberOfRemainingBytes * 8;
            selectedPredictor = bitReader.ReadNBits(4);
            numberOfRemainingBits -= 4;
            int row = 0; int column = 0;
            while (numberOfRemainingBits >= 9)
            {
                uint sign = bitReader.ReadNBits(1);
                if (sign == 0)
                {
                    errorMatrix[row, column] = (int)bitReader.ReadNBits(8);
                }
                else
                {
                    errorMatrix[row, column] = (int)bitReader.ReadNBits(8) * -1;
                }
                column++;
                if (column == 256)
                {
                    column = 0;
                    row++;
                }
                numberOfRemainingBits -= 9;
            }

            bitReader.CloseFile();
        }

        public int[,] GetImageMatrix()
        {
            return imageMatrix;
        }

        public void DecodeImage()
        {
            if (selectedPredictor == 0)
            {
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        imageMatrix[i, j] = 128 + errorMatrix[i, j];
                    }
                }
            }
            else
            {
                predictionMatrix[0, 0] = 128;
                imageMatrix[0, 0] = predictionMatrix[0, 0] + errorMatrix[0, 0];

                for (int i = 1; i < 256; i++)
                {
                    predictionMatrix[0, i] = imageMatrix[0, i - 1];
                    predictionMatrix[i, 0] = imageMatrix[i - 1, 0];

                    imageMatrix[0, i] = predictionMatrix[0, i] + errorMatrix[0, i];
                    imageMatrix[i, 0] = predictionMatrix[i, 0] + errorMatrix[i, 0];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
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
                                imageMatrix[i, j] = predictionMatrix[i, j] + errorMatrix[i, j];
                            }
                        }
                        break;
                }
            }
        }

        public void StoreDecodedImage()
        {
            outputFilePath += ".decoded.bmp";
            bitWriter = new BitWriter(outputFilePath);
            for (int i = 0; i < 1078; i++)
            {
                bitWriter.WriteNBits(8, imageHeader[i]);
            }
            for (int i = 255; i >= 0; i--)
            {
                for (int j = 0; j < 256; j++)
                {
                    bitWriter.WriteNBits(8, (uint)imageMatrix[i, j]);
                }
            }

            bitWriter.CloseFile();
        }
    }
}
