using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPManagerSYS
{
    internal static class Program//架构搭建:管理我们的文件和组织我们的代码
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmLogin frmlogin = new FrmLogin();
            //DialogResult dialogResult = frmlogin.ShowDialog();
            //if (dialogResult == DialogResult.OK) { Application.Run(new Main()); }
            //else { Application.Exit(); }
            Application.Run(new Main());
        }
    }
}
