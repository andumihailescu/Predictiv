using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predictiv
{
    internal class Prediction
    {
        uint[,] predictionMatrix = new uint[256, 256];
        uint[,] errorMatrix = new uint[256, 256];

        uint selectedPredictor = 0;

        private void calculatePredictionMatrix()
        {
            switch (selectedPredictor)
            {
                case 0:
                    for(int i = 0; i < 256; i++)
                    {
                        for(int j = 0; j < 256; j++)
                        {
                            predictionMatrix[i, j] = 128;
                        }
                    }
                    break;
                case 1:
                    



                    break;
                case 2:
                    break;
            }
        }

    }
}
