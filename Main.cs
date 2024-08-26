using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPManagerSYS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            FrmAddStaff frmAddStaff = new FrmAddStaff();
            //frmAddStaff.Show();
            OpenForm(frmAddStaff);
        }
        private void btnCusManage_Click(object sender, EventArgs e)
        {
            CustomManager frmCustomManager = new CustomManager();
            OpenForm(frmCustomManager);
        }
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            FrmStaffManager frmStaffManager = new FrmStaffManager();
            OpenForm(frmStaffManager);
        }
        private void OpenForm(Form form) { 
            this.splitContainer1.Panel2.Controls.Clear();//清空容器
            form.TopLevel = false;//非顶级窗体
            form.FormBorderStyle = FormBorderStyle.None;//没有边框
            form.Parent = this.splitContainer1.Panel2;//设置窗体的父容器
            form.Dock= DockStyle.Fill;//填充父容器
            form.Show();
        }
    }
}
