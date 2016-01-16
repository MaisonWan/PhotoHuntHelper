using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace 找茬助手
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        long begin;
        long end;
        private void button1_Click(object sender, EventArgs e)
        {
            //begin = DateTime.Now.Ticks;
            //Color currentColor;
            //int r;
            //Bitmap currentBitmap = new Bitmap(pictureBox1.Image);
            //Graphics g = Graphics.FromImage(currentBitmap);
            //for (int w = 0; w < currentBitmap.Width; w++)
            //{
            //    for (int h = 0; h < currentBitmap.Height; h++)
            //    {
            //        currentColor = currentBitmap.GetPixel(w, h);
            //        r = (currentColor.R + currentColor.G + currentColor.B) / 3;
            //        currentBitmap.SetPixel(w, h, Color.FromArgb(r, r, r));
            //    }
            //}
            //g.DrawImage(currentBitmap, 0, 0);
            //pictureBox1.Image = currentBitmap;
            //g.Dispose();
            //end = DateTime.Now.Ticks;
            //label1.Text = (end - begin) / 1000 + "毫秒";
            this.pictureBox1.Image = this.ToReliefImage(pictureBox1.Image, 128);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            begin = DateTime.Now.Ticks;
            
            Bitmap currentBitmap = new Bitmap(pictureBox1.Image);
            Graphics g = Graphics.FromImage(currentBitmap);

            ImageAttributes ia = new ImageAttributes();

            float[][] colorMatrix =   {
                new float[] {0.299f,   0.299f,   0.299f,   0,   0},
                new float[]   {0.587f,   0.587f,   0.587f,   0,   0},
                new float[]   {0.114f,   0.114f,   0.114f,   0,   0},
                new float[]   {0,   0,   0,   1,   0},
                new float[]   {0,   0,   0,   0,   1}
                                      };

            ColorMatrix cm = new ColorMatrix(colorMatrix);

            ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            g.DrawImage(currentBitmap, new Rectangle(0, 0, currentBitmap.Width, currentBitmap.Height), 0, 0, currentBitmap.Width, currentBitmap.Height, GraphicsUnit.Pixel, ia);

            pictureBox1.Image = currentBitmap;

            g.Dispose();
            end = DateTime.Now.Ticks;
            label1.Text = (end - begin) / 1000 + "毫秒";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::找茬助手.Properties.Resources.leftImage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">浮雕图像的n的值通常是128</param>
        /// <returns></returns>
        public Bitmap ToReliefImage(Image image, int n)
        {
            if (n < 0) n = 0;
            if (n > 255) n = 255;
            Bitmap bitmap = new Bitmap(image);
            Color c = new Color();
            Color c1 = new Color();
            Color c2 = new Color();
            int r, g, b;
            for (int i = 1; i < bitmap.Size.Width; i++)
            {
                for (int j = 0; j < bitmap.Size.Height; j++)
                {
                    c1 = bitmap.GetPixel(i, j);
                    c2 = bitmap.GetPixel(i - 1, j);
                    r = c1.R - c2.R + n;
                    g = c1.G - c2.G + n;
                    b = c1.B - c2.B + n;
                    c = Color.FromArgb(r, g, b);
                    bitmap.SetPixel(i, j, c);
                }
            }
            return bitmap;
        }
    }
}
