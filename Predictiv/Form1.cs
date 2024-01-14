using System.Windows.Forms;

namespace Predictiv
{
    public partial class Form1 : Form
    {
        private Encoder encoder;
        private uint predictionNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP Files|*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);

                    pbOriginalImage.Image = bmp;

                    encoder = new Encoder(bmp, openFileDialog.FileName);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            CheckPredictionButtons();

            encoder.SetSelectedPredictor(predictionNumber);

            encoder.CalculatePredictionMatrix();
        }

        private void CheckPredictionButtons()
        {
            if (rb128.Checked)
            {
                predictionNumber = 0;
            }
            if (rbA.Checked)
            {
                predictionNumber = 1;
            }
            if (rbB.Checked)
            {
                predictionNumber = 2;
            }
            if (rbC.Checked)
            {
                predictionNumber = 3;
            }
            if (rbABC.Checked)
            {
                predictionNumber = 4;
            }
            if (rbABC2.Checked)
            {
                predictionNumber = 5;
            }
            if (rbBAC2.Checked)
            {
                predictionNumber = 6;
            }
            if (rbAB2.Checked)
            {
                predictionNumber = 7;
            }
        }

        private void displayImage(int[,] imageMatrix)
        {
            Bitmap bmp = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int pixelValue = 128 + imageMatrix[j, i] * 2;
                    bmp.SetPixel(i, j, Color.FromArgb(pixelValue, pixelValue, pixelValue));
                }
            }
            pbErrorImage.Image = bmp;
        }

        private void btnShowErrorMatrix_Click(object sender, EventArgs e)
        {
            encoder.CalculateErrorMatrix();
            displayImage(encoder.GetErrorMatrix());
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            encoder.EncodeImage();
        }
    }
}
