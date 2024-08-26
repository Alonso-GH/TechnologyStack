using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ERPManagerSYS
{
    public partial class FrmLogin : Form
    {
        AdminService adminService = new AdminService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SysAdmin sysAdmin = new SysAdmin() { LoginId= Convert.ToInt32(this.txtLoginName.Text.Trim()),LoginPwd=this.txtLoginPwd.Text.Trim()};
            SysAdmin newAdmin = adminService.GetSysAdmin(sysAdmin);
            if (newAdmin.AdminName != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("账号或者密码输入错误，请重新输入!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
