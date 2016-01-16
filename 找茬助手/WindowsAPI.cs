using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace 找茬助手
{
    /// <summary>
    /// Window窗口操作API
    /// </summary>
    public class WindowsAPI
    {
        /// <summary>
        /// 得到指定窗口
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName">窗口标题</param>
        /// <returns>窗口句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 得到指定窗口的位置和坐标
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        /// <summary>
        /// 窗口的坐标
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;                          //最左坐标
            public int Top;                           //最上坐标
            public int Right;                         //最右坐标
            public int Bottom;                        //最下坐标
        }
    }
}
