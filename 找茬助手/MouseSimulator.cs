using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace 找茬助手
{
    /// <summary>
    /// 鼠标模拟器
    /// </summary>
    public static class MouseSimulator
    {

        #region Windows API Code

        [DllImport("user32.dll")]
        public static extern int ShowCursor(bool show);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int flags, int dX, int dY, int buttons, int extraInfo);

        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void GetCursorPos(out MousePoint point);

        #endregion

        #region Properties
        /// <summary>
        /// 鼠标位置
        /// </summary>
        public static MousePoint Position
        {
            get
            {
                return new MousePoint(Cursor.Position);
            }
            set
            {
                Cursor.Position = value;
            }
        }

        /// <summary>
        /// 鼠标位置横坐标
        /// </summary>
        public static int X
        {
            get
            {
                return Cursor.Position.X;
            }
            set
            {
                Cursor.Position = new Point(value, Y);
            }
        }
        /// <summary>
        /// 鼠标纵坐标
        /// </summary>
        public static int Y
        {
            get
            {
                return Cursor.Position.Y;
            }
            set
            {
                Cursor.Position = new Point(X, value);
            }
        } 
        #endregion

        #region Methods

        /// <summary>
        /// 按下鼠标指定按键
        /// </summary>
        /// <param name="button"></param>
        public static void MouseDown(MouseButton button)
        {
            mouse_event(((int)button), 0, 0, 0, 0);
        }

        /// <summary>
        /// 鼠标按钮组合选择
        /// </summary>
        /// <param name="button"></param>
        public static void MouseDown(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    MouseDown(MouseButton.Left);
                    break;
                case MouseButtons.Middle:
                    MouseDown(MouseButton.Middle);
                    break;
                case MouseButtons.Right:
                    MouseDown(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 弹起鼠标指定按键
        /// </summary>
        /// <param name="button"></param>
        public static void MouseUp(MouseButton button)
        {
            mouse_event(((int)button) * 2, 0, 0, 0, 0);
        }

        /// <summary>
        /// 抬起鼠标按键的组合选择
        /// </summary>
        /// <param name="button"></param>
        public static void MouseUp(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    MouseUp(MouseButton.Left);
                    break;
                case MouseButtons.Middle:
                    MouseUp(MouseButton.Middle);
                    break;
                case MouseButtons.Right:
                    MouseUp(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 单击鼠标指定按键
        /// </summary>
        /// <param name="button"></param>
        public static void Click(MouseButton button)
        {
            MouseDown(button);
            MouseUp(button);
        }

        /// <summary>
        /// 单击鼠标指定按键组合
        /// </summary>
        /// <param name="button">鼠标按键</param>
        public static void Click(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    Click(MouseButton.Left);
                    break;
                case MouseButtons.Middle:
                    Click(MouseButton.Middle);
                    break;
                case MouseButtons.Right:
                    Click(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 双击鼠标指定按键
        /// </summary>
        /// <param name="button">鼠标按键</param>
        public static void DoubleClick(MouseButton button)
        {
            Click(button);
            Click(button);
        }

        /// <summary>
        /// 双击鼠标指定按键组合
        /// </summary>
        /// <param name="button">鼠标按键</param>
        public static void DoubleClick(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    DoubleClick(MouseButton.Left);
                    break;
                case MouseButtons.Middle:
                    DoubleClick(MouseButton.Middle);
                    break;
                case MouseButtons.Right:
                    DoubleClick(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 显示鼠标
        /// </summary>
        public static void Show()
        {
            ShowCursor(true);
        }

        /// <summary>
        /// 隐藏鼠标
        /// </summary>
        public static void Hide()
        {
            ShowCursor(false);
        }
        #endregion
    }
}
