using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 找茬助手
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (WindowsAPI.FindWindow(null, "大家来找茬") == IntPtr.Zero)
            {
                if (MessageBox.Show("请先打开“美女找茬”，然后点击“确定”", "提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
