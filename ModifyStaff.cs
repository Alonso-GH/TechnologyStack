using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPManagerSYS
{
    public partial class ModifyStaff : Form
    {
        StaffService staffService = new StaffService();
        DepartmentService departmentService = new DepartmentService();
        EducationService educationService = new EducationService();
        PostService postService = new PostService();
        string JobNum = null;
        public ModifyStaff(string staffJobNum)
        {
            JobNum = staffJobNum;
            InitializeComponent();
            this.cmbDepartment.DataSource = departmentService.GetDepartment();
            this.cmbDepartment.DisplayMember = "DepartmentName"; this.cmbDepartment.ValueMember = "DepartmentId";
            this.cmbEducation.DataSource = educationService.GetEducation();
            this.cmbEducation.DisplayMember = "EducationName"; this.cmbEducation.ValueMember = "EducationId";
            this.cmbPost.DataSource = postService.GetPosts();
            this.cmbPost.DisplayMember = "PostName"; this.cmbPost.ValueMember = "PostId";
            List<Staff> stafflist=staffService.GetStaffListByJobNum(staffJobNum);
            this.txtStaffName.Text = stafflist[0].StaffName;
            this.dtpBirthday.Value = stafflist[0].Birthday;
            this.txtJobNum.Text = stafflist[0].JobNum;
            this.picPhoto.Text = stafflist[0].StaffIamage;
            this.txtAge.Text = stafflist[0].Age.ToString();
            this.txtPhone.Text = stafflist[0].Phone;
            this.txtAddress.Text = stafflist[0].StaffAddress;
            this.txtIdentity.Text = stafflist[0].IdentityNum;
            this.cmbDepartment.SelectedValue = stafflist[0].DepartmentId;
            this.cmbEducation.SelectedValue = stafflist[0].EducationId;
            this.cmbPost.SelectedValue = stafflist[0].PostId;
            if (stafflist[0].Grender == "男") this.rdoMale.Checked = true; else this.rdoFemale.Checked = true;
        }

        private void btnModifyStaff_Click(object sender, EventArgs e)
        {
            if (this.txtStaffName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入姓名", "信息提示");
                return;
            }
            if (this.txtPhone.Text.Trim().Length == 0 && !Regex.IsMatch(this.txtPhone.Text.Trim(), "^[0-9]*$"))
            {
                MessageBox.Show("请输入正确电话号码", "信息提示");
                return;
            }
            Staff staff = new Staff()
            {
                StaffName = this.txtStaffName.Text.Trim(),
                Grender = this.rdoMale.Checked == true ? "男" : "女",
                Phone = this.txtPhone.Text.Trim(),
                JobNum = JobNum.Trim().ToString(),
                StaffAddress = this.txtAddress.Text.Trim(),
                Birthday = this.dtpBirthday.Value,
                StaffIamage = this.picPhoto.ImageLocation,
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                DepartmentId = Convert.ToInt32(this.cmbDepartment.SelectedValue),
                PostId = Convert.ToInt32(this.cmbPost.SelectedValue),
                EducationId = Convert.ToInt32(this.cmbEducation.SelectedValue),
                IdentityNum = this.txtIdentity.Text.Trim(),
            };
            bool result=staffService.UpdateStaffInfo(staff);
            if (result)
            {
                MessageBox.Show("修改成功!","信息提示");
            }
        }
    }
}
