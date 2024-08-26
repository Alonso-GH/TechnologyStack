using DAL;
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

namespace ERPManagerSYS
{
    public partial class FrmStaffManager : Form
    {
        StaffService staffService = new StaffService();
        DepartmentService departmentService = new DepartmentService();
        PostService postService = new PostService();
        EducationService educationService = new EducationService();
        public FrmStaffManager()
        {
            InitializeComponent();
            //this.dgvStaffList.AutoGenerateColumns = false;//禁止自动加载列
            //this.dgvStaffList.DataSource = staffService.GetAllStaff();//填充表格数据
            this.cmbDepartment.DataSource = departmentService.GetDepartment();
            this.cmbDepartment.DisplayMember = "DepartmentName";
            this.cmbDepartment.ValueMember = "DepartmentId";
            this.cmbDepartment.SelectedIndex = -1;
            this.cmbEducation.DataSource = postService.GetPosts();
            this.cmbEducation.DisplayMember = "PostName";
            this.cmbEducation.ValueMember = "PostId";
            this.cmbEducation.SelectedIndex = -1;
            this.cmbPost.DataSource = educationService.GetEducation();
            this.cmbPost.DisplayMember = "EducationName";
            this.cmbPost.ValueMember = "EducationId";
            this.cmbPost.SelectedIndex = -1;
        }
        string staffJobNum = null;
        private void dgvStaffList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvStaffList.ClearSelection();
                this.dgvStaffList.Rows[e.RowIndex].Selected = true;
                this.contextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                //this.dgvStaffList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();点击RowIndex行位置ColumnIndex列的位置
                staffJobNum = this.dgvStaffList.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffDetail staffDetail = new StaffDetail(staffJobNum);
            staffDetail.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.txtJobNum.Text.Trim().Length > 0)
            {
                this.dgvStaffList.DataSource = staffService.GetStaffListByJobNum(this.txtJobNum.Text.Trim());
            }
            else if (this.txtStaffName.Text.Trim().Length > 0)
            {
                this.dgvStaffList.DataSource = staffService.GetStaffListByStaffName(this.txtStaffName.Text.Trim());
            }
            else if (this.cmbDepartment.SelectedIndex > -1)
            {
                this.dgvStaffList.DataSource = staffService.GetStaffListByDepartmentId(this.cmbDepartment.SelectedValue.ToString());
            }
            else if (this.cmbEducation.SelectedIndex > -1)
            {
                this.dgvStaffList.DataSource = staffService.GetStaffListByEducationId(this.cmbEducation.SelectedValue.ToString());
            }
            else if (this.cmbPost.SelectedIndex > -1)
            {
                this.dgvStaffList.DataSource = staffService.GetStaffListByPostId(this.cmbPost.SelectedValue.ToString());
            }
            else
            {
                this.dgvStaffList.DataSource = this.dgvStaffList.DataSource = staffService.GetAllStaff();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyStaff modifyStaff = new ModifyStaff(staffJobNum);
            modifyStaff.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isDelete = staffService.DeleteStaffInfo(staffJobNum);
            if (isDelete) MessageBox.Show("删除成功");
            else MessageBox.Show("删除失败");
        }
    }
}
