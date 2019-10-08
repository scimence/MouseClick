using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    /// <summary>
    /// 点击From界面上的按钮后，延时1.2秒模拟鼠标点击（在鼠标左右，单个按键损坏可用）
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int F = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (F == 1) LeftCick();
            else if (F == 2) RightCick();
            else if (F == 3)
            {
                LeftCick();
                LeftCick();
            }
            else if (F == 4)
            {
                RightCick();
                RightCick();
            }

            timer1.Enabled = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            F = 1;
            timer1.Enabled = true;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            F = 2;
            timer1.Enabled = true;
        }

        private void buttonLD_Click(object sender, EventArgs e)
        {
            F = 3;
            timer1.Enabled = true;
        }

        private void buttonRD_Click(object sender, EventArgs e)
        {
            F = 4;
            timer1.Enabled = true;
        }

        #region 模拟鼠标操作

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;


        /// <summary>
        /// 鼠标右键点击
        /// </summary>
        public static void RightCick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        /// <summary>
        /// 鼠标左键点击
        /// </summary>
        public static void LeftCick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        #endregion


    }
}
