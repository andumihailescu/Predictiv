using Bit_Reader_Writer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predictiv
{
    internal class Image
    {
        private uint[,] imageMatrix = new uint[256, 256];
        private BitReader bitReader;
        private long fileLength;
        private long numberOfRemainingBytes;
        private uint[] imageHeader = new uint[1078];

        public uint[,] GetImageMatrix()
        {
            return imageMatrix;
        }

        public Image(Bitmap bmp, string inputFilePath)
        {
            bitReader = new BitReader(inputFilePath);
            fileLength = bitReader.GetFileLengthInBytes();

            for (int i = 0; i < 1078; i++)
            {
                imageHeader[i] = bitReader.ReadNBits(8);
            }
            numberOfRemainingBytes = fileLength - 1078;
            int row = 255; int column = 0;
            while (numberOfRemainingBytes > 0)
            {
                imageMatrix[row,column] = bitReader.ReadNBits(8);
                column++;
                if (column == 256)
                {
                    column = 0;
                    row--;
                }
                numberOfRemainingBytes--;
            }

        }


    }
}
