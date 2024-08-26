using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPManagerSYS
{
    public partial class StaffDetail : Form
    {
        StaffService staffService = new StaffService();
        public StaffDetail(string staffJobNum)
        {
            InitializeComponent();
            this.txtJobNum.Enabled = false;
            this.txtStaffName.Enabled = false;
            this.rdoMale.Enabled = false;
            this.rdoFemale.Enabled = false;
            this.txtPhone.Enabled = false;
            this.cmbDepartment.Enabled = false;
            this.cmbPost.Enabled = false;
            this.cmbEducation.Enabled = false;
            this.dtpBirthday.Enabled = false;
            this.txtIdentity.Enabled = false;
            this.txtAddress.Enabled = false;
            Staff staff = staffService.GetStaffDetail(staffJobNum);
            this.txtJobNum.Text = staff.JobNum;
            this.txtStaffName.Text = staff.StaffName;
            if (staff.Grender == "男") this.rdoMale.Checked = true;
            else this.rdoFemale.Checked = true;
            this.txtPhone.Text = staff.Phone;
            this.cmbDepartment.Text = staff.Department;
            this.cmbPost.Text = staff.Post;
            this.cmbEducation.Text = staff.Education;
            this.dtpBirthday.Text = staff.Birthday.ToString();
            this.txtIdentity.Text = staff.IdentityNum;
            this.txtAddress.Text = staff.StaffAddress;
            this.picPhoto.ImageLocation = staff.StaffIamage==""? staff.StaffIamage : Directory.GetCurrentDirectory()+"\\Image\\"+ staff.StaffIamage;
        }
    }
}
