using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtsuMethod
{
    public partial class Form1 : Form
    {  
        static   public  int[] thresholds = new int[4];


        private LevelsOfGray32 otsu32grayLevels = new LevelsOfGray32();
        private LevelsOfGray64 otsu64grayLevels = new LevelsOfGray64();
        private LevelsOfGray256 otsu256grayLevels = new LevelsOfGray256();
        private Bitmap InputImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputImage = (Bitmap)pictureBox1.Image.Clone();
        }

        private void Open_Image_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                InputImage = (Bitmap)pictureBox1.Image.Clone();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void Save_Image_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void Exit_StripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OriginalImage64_Click(object sender, EventArgs e)
        {
            Bitmap temporary = (Bitmap)InputImage.Clone();

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = temporary;

            Application.DoEvents();
        }

        private void GrayImage64_Click(object sender, EventArgs e)
        {
            Bitmap temporary = (Bitmap)InputImage.Clone();

            otsu64grayLevels.ConvertingToGrayScale(temporary);

            pictureBox1.Image = temporary;

            Application.DoEvents();


           long[] myValues = otsu64grayLevels.Histogram(new Bitmap(pictureBox1.Image));

           drawHistogram1.DrawHistogramm(myValues);  
        }

        private void OriginalImage32_Click(object sender, EventArgs e)
        {
            Bitmap temporary = (Bitmap)InputImage.Clone();
       
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = temporary;

            Application.DoEvents();

        }

        private void GrayImage32_Click(object sender, EventArgs e)
        {
            Bitmap temporary = (Bitmap)InputImage.Clone();

            otsu32grayLevels.ConvertingToGrayScale(temporary);

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = temporary;

            Application.DoEvents();

            long[] myValues = otsu32grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);
        }

        private void TwoClassesThreshold32_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu32grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu32grayLevels.Histogram(temporary);

            float[,] P = new float[32, 32];
            float[,] S = new float[32, 32];
            float[,] H = new float[32, 32];

            otsu32grayLevels.CalculateValues(P, S, H, hist);

            float maxSigma = otsu32grayLevels.findMaxSigma2classes(H, thresholds);

            otsu32grayLevels.Binarization(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
    
            Application.DoEvents();

            long[] myValues = otsu32grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
        }

        private void TwoClassesThreshold64_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu64grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu64grayLevels.Histogram(temporary);

            float[,] P = new float[64, 64];
            float[,] S = new float[64, 64];
            float[,] H = new float[64, 64];

            otsu64grayLevels.CalculateValues(P, S, H, hist);

         
            float maxSigma = otsu64grayLevels.findMaxSigma2classes(H, thresholds);

            otsu64grayLevels.Binarization(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
  
            Application.DoEvents();

            long[] myValues = otsu64grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
        }

        private void OriginalImage256_Click(object sender, EventArgs e)
        {
            Bitmap temporary = (Bitmap)InputImage.Clone();

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = temporary;

            Application.DoEvents();
        }

        private void GrayImage256_Click(object sender, EventArgs e)
        {
            thresholds[1] = 0;
            thresholds[2] = 0;
            thresholds[3] = 0;

            Bitmap temporary = (Bitmap)InputImage.Clone();

            otsu256grayLevels.ConvertingToGrayScale(temporary);

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = temporary;

            Application.DoEvents();

            long[] myValues = otsu256grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);
        }
        private void TwoClassesThreshold256_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            thresholds[0] = 0;
            thresholds[1] = 0;
            thresholds[2] = 0;
            thresholds[3] = 0;

            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu256grayLevels.ConvertingToGrayScale(temporary);
            Bitmap pragovahistograma = (Bitmap)temporary.Clone();

            long[] hist = otsu256grayLevels.Histogram(temporary);

            float[,] P = new float[256, 256];
            float[,] S = new float[256, 256];
            float[,] H = new float[256, 256];

            otsu256grayLevels.CalculateValues(P, S, H, hist);

         
            float maxSigma = otsu256grayLevels.findMaxSigma2classes(H, thresholds);

            otsu256grayLevels.Binarization(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
     
            Application.DoEvents();

            long[] myValues = otsu256grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);
        }

        private void ThreeCLassesThreshold256_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            thresholds[0] = 0;
            thresholds[1] = 0;
            thresholds[2] = 0;
            thresholds[3] = 0;

            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu256grayLevels.ConvertingToGrayScale(temporary);
            Bitmap pragovahistograma = (Bitmap)temporary.Clone();

            long[] hist = otsu256grayLevels.Histogram(temporary);

             float [,] P = new float[256,256];
             float [,] S = new float[256,256];
             float [,] H = new float[256,256];

             otsu256grayLevels.CalculateValues(P,S,H,hist);

       
           float maxSigma = otsu256grayLevels.findMaxSigma3classes(H, thresholds);

           otsu256grayLevels.Binarization2(temporary, thresholds);

           pictureBox1.Image = temporary;

           textBox1.Text = thresholds[1].ToString();
           textBox7.Text = thresholds[2].ToString();
                
           Application.DoEvents();

           long[] myValues = otsu256grayLevels.Histogram(new Bitmap(pictureBox1.Image));

           drawHistogram1.DrawHistogramm(myValues);   
            
        }

        private void ThreeClassesThreshold32_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();

            Bitmap sivoizobravenie = otsu32grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu32grayLevels.Histogram(temporary);

            float[,] P = new float[32, 32];
            float[,] S = new float[32, 32];
            float[,] H = new float[32, 32];

            otsu32grayLevels.CalculateValues(P, S, H, hist);

         
            float maxSigma = otsu32grayLevels.findMaxSigma3classes(H, thresholds);

            otsu32grayLevels.Binarization2(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
            textBox7.Text = thresholds[2].ToString();
    
            Application.DoEvents();

            long[] myValues = otsu32grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
        }

        private void FourClassesThreshold32_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu32grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu32grayLevels.Histogram(temporary);

            float[,] P = new float[32, 32];
            float[,] S = new float[32, 32];
            float[,] H = new float[32, 32];

            otsu32grayLevels.CalculateValues(P, S, H, hist);

       
            float maxSigma = otsu32grayLevels.findMaxSigma4classes(H, thresholds);

            otsu32grayLevels.Binarization3(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
            textBox7.Text = thresholds[2].ToString();
            textBox8.Text = thresholds[3].ToString();
          
            Application.DoEvents();

            long[] myValues = otsu32grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
        }

        private void ThreeClassesThreshold64_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu64grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu64grayLevels.Histogram(temporary);

            float[,] P = new float[64, 64];
            float[,] S = new float[64, 64];
            float[,] H = new float[64, 64];

            otsu64grayLevels.CalculateValues(P, S, H, hist);

        
            float maxSigma = otsu64grayLevels.findMaxSigma3classes(H, thresholds);

            otsu64grayLevels.Binarization2(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
            textBox7.Text = thresholds[2].ToString();
         
            Application.DoEvents();

            long[] myValues = otsu64grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
        }

        private void FourClassesThreshold64_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();


            Bitmap temporary = (Bitmap)InputImage.Clone();
            Bitmap sivoizobravenie = otsu64grayLevels.ConvertingToGrayScale(temporary);

            long[] hist = otsu64grayLevels.Histogram(temporary);

            float[,] P = new float[64, 64];
            float[,] S = new float[64, 64];
            float[,] H = new float[64, 64];

            otsu64grayLevels.CalculateValues(P, S, H, hist);

            float maxSigma = otsu64grayLevels.findMaxSigma4classes(H, thresholds);

            otsu64grayLevels.Binarization3(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
            textBox7.Text = thresholds[2].ToString();
            textBox8.Text = thresholds[3].ToString();
          
            Application.DoEvents();

            long[] myValues = otsu64grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);  
        }

        private void FourClassesThreshold256_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();

            thresholds[1] = 0;
            thresholds[2] = 0;
            thresholds[3] = 0;

            Bitmap temporary = (Bitmap)InputImage.Clone();

            Bitmap sivoizobravenie = otsu256grayLevels.ConvertingToGrayScale(temporary);

            Bitmap pragovaHistograma = (Bitmap)temporary.Clone();

            long[] hist = otsu256grayLevels.Histogram(temporary);

            float[,] P = new float[256, 256];
            float[,] S = new float[256, 256];
            float[,] H = new float[256, 256];

            otsu256grayLevels.CalculateValues(P, S, H, hist);

            float maxSigma = otsu256grayLevels.findMaxSigma4classes(H, thresholds);

            otsu256grayLevels.Binarization3(temporary, thresholds);

            pictureBox1.Image = temporary;

            textBox1.Text = thresholds[1].ToString();
            textBox7.Text = thresholds[2].ToString();
            textBox8.Text = thresholds[3].ToString();
          
            Application.DoEvents();

            long[] myValues = otsu256grayLevels.Histogram(new Bitmap(pictureBox1.Image));

            drawHistogram1.DrawHistogramm(myValues);   
            
        }

    }
}
