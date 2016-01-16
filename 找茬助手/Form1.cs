using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace 找茬助手
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 透明度
        /// </summary>
        private double[] n = { 0.05, 0.3, 0.6, 0.9, 0.6, 0.3 };
        /// <summary>
        /// 抓图的偏移量，根据系统不同，偏移量不同
        /// </summary>
        private int pictureP;
        /// <summary>
        /// 显示原图
        /// </summary>
        private FormCompare forCompare = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
            if (Environment.OSVersion.Version.Major == 5)
            {
                // XP系统偏移量
                pictureP = 29;
            }
            else if (Environment.OSVersion.Version.Major == 6)
            {
                // Win7系统偏移量
                pictureP = 26;
            }
            InitLocation();

            this.forCompare = new FormCompare();
            this.forCompare.Location = new Point(this.Location.X - this.forCompare.Width, this.Location.Y);
            //this.forCompare.Location = new Point(-10, 10);
            //this.forCompare.Top = this.Top;
            //this.forCompare.Left = this.Left - this.forCompare.Width;
            this.forCompare.Show();
        }

        /// <summary>
        /// 初始化本地窗口的位置
        /// </summary>
        private void InitLocation()
        {
            IntPtr gameWindows = WindowsAPI.FindWindow(null, "大家来找茬");
            WindowsAPI.RECT rect = new WindowsAPI.RECT();
            WindowsAPI.GetWindowRect(gameWindows, ref rect);
            if (gameWindows != IntPtr.Zero)
            {
                this.Location = new Point(rect.Left + 1, rect.Top + 190 - pictureP);
            }
        }
        /// <summary>
        /// 次序
        /// </summary>
        private int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if (num == 6)
            {
                num = 0;
            }
            this.Opacity = n[num];
        }

        /// <summary>
        /// 开始/暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                this.Opacity = 0.7;
                this.timer1.Stop();
            }
            else
            {
                this.timer1.Start();
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReflush_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Opacity = 0;
            Thread.Sleep(100);
            Image leftImage = this.GetScreenImage(new Point(this.Location.X + 3, this.Location.Y + pictureP));
            Image rightImage = this.GetScreenImage(new Point(this.Location.X + 513, this.Location.Y + pictureP));
            this.pictureBoxRight.Image = leftImage;
            this.pictureBoxLeft.Image = rightImage;

            this.forCompare.LeftImage = leftImage;
            this.forCompare.RightImage = rightImage;
            this.timer1.Start();
            //leftImage.Save("left.jpg");
            //rightImage.Save("right.jpg");
        }

        /// <summary>
        /// 得到当前屏幕的图像
        /// </summary>
        private Image GetScreenImage(Point point)
        {
            Image image = new Bitmap(500, 450);
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(point, new Point(0, 0), new Size(500, 450));
            return image;
        }

        /// <summary>
        /// 当窗口获得焦点的时候自动抓图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                buttonReflush_Click(sender, e);
            }
        }

        /// <summary>
        /// 单击左边图片发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.timer1.Enabled)
            {
                // 按下左键
                if (e.Button == MouseButtons.Left)
                {
                    int x = this.Location.X + this.pictureBoxLeft.Location.X + e.X + 3;
                    int y = this.Location.Y + this.pictureBoxLeft.Location.Y + e.Y + pictureP;
                    MouseSimulator.Position = new MousePoint(new Point(x, y));
                    this.timer1.Stop();
                    Thread.Sleep(50);
                    this.Opacity = 0.0;
                    MouseSimulator.Click(MouseButton.Left);
                    this.timer1.Start();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    buttonReflush_Click(sender, e);
                }
            }
        }

        private void pictureBoxRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.timer1.Enabled)
            {
                // 按下左键
                if (e.Button == MouseButtons.Left)
                {
                    int x = this.Location.X + this.pictureBoxLeft.Location.X + e.X + 513;
                    int y = this.Location.Y + this.pictureBoxLeft.Location.Y + e.Y + pictureP;
                    MouseSimulator.Position = new MousePoint(new Point(x, y));
                    this.timer1.Stop();
                    Thread.Sleep(50);
                    this.Opacity = 0.0;
                    MouseSimulator.Click(MouseButton.Left);
                    this.timer1.Start();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    buttonReflush_Click(sender, e);
                }
            }
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        /// <summary>
        /// 置于前端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTop_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                this.buttonTop.Text = "置于前端(&F)";
            }
            else
            {
                this.TopMost = true;
                this.buttonTop.Text = "取消前置(&F)";
            }
        }

        /// <summary>
        /// 开始上点击左键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = this.Location.X + this.panelStart.Location.X + e.X + 3;
                int y = this.Location.Y + this.panelStart.Location.Y + e.Y + pictureP;
                MouseSimulator.Position = new MousePoint(new Point(x, y));
                this.timer1.Stop();
                Thread.Sleep(50);
                this.Opacity = 0.0;
                MouseSimulator.Click(MouseButton.Left);
                this.timer1.Start();
            }
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.forCompare != null)
            {
                this.forCompare.Close();
            }
        }
    }
}
