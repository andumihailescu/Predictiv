using System.Windows.Forms;

namespace Predictiv
{
    public partial class Form1 : Form
    {

        private Image image;

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

                    image = new Image(bmp, openFileDialog.FileName);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for(int j = 0; j < 256; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb((int)image.GetImageMatrix()[j, i], (int)image.GetImageMatrix()[j, i], (int)image.GetImageMatrix()[j, i]));
                }
            }
            pbErrorImage.Image = bmp;
        }
    }
}
