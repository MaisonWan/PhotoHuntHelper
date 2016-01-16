using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace 找茬助手
{
    /// <summary>
    /// 鼠标位置
    /// </summary>
    public struct MousePoint
    {
        /// <summary>
        /// 鼠标X位置
        /// </summary>
        public int X;
        /// <summary>
        /// 鼠标Y位置
        /// </summary>
        public int Y;

        /// <summary>
        /// 屏幕点坐标
        /// </summary>
        /// <param name="p"></param>
        public MousePoint(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static implicit operator Point(MousePoint p)
        {
            return new Point(p.X, p.Y);
        }
    }
}
