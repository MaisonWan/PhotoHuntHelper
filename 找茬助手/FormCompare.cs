using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 找茬助手
{
    public partial class FormCompare : Form
    {
        public FormCompare()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否按下左键
        /// </summary>
        private bool isPress = false;
        private Point pressPoint = Point.Empty;

        public Image LeftImage
        {
            set
            {
                this.pictureBoxLeft.Image = value;
            }
        }

        public Image RightImage
        {
            set
            {
                this.pictureBoxRight.Image = value;
            }
        }

        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPress = true;
                pressPoint = e.Location;
                
            }
        }

        /// <summary>
        /// 鼠标抬起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPress = false;
            }
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isPress)
            {
                this.Location = new Point(this.Location.X + e.X - this.pressPoint.X, this.Location.Y + e.Y - this.pressPoint.Y);
            }
        }

        private void pictureBoxRight_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBoxLeft_MouseDown(sender, e);
        }

        private void pictureBoxRight_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBoxLeft_MouseUp(sender, e);
        }

        private void pictureBoxRight_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBoxLeft_MouseMove(sender, e);
        }
    }
}
