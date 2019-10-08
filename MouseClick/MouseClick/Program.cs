using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 根据参数执行鼠标点击逻辑l、r、ll、rr
            if (args != null && args.Length > 0)           
            {
                String arg = args[0].Trim().ToLower();  
                //MessageBox.Show(arg);

                if (arg.Equals("l")) Form1.LeftCick();
                else if (arg.Equals("r")) Form1.RightCick(); 
                else if (arg.Equals("ll"))
                {
                    Form1.LeftCick();
                    Form1.LeftCick();
                }
                else if (arg.Equals("rr"))
                {
                    Form1.RightCick();
                    Form1.RightCick();
                }
            }
            else Application.Run(new Form1());
        }
    }
}
