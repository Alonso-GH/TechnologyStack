using AForge.Video.DirectShow;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPManagerSYS
{
    public partial class FrmAddStaff : Form
    {
        FilterInfoCollection videoDevices;//获取摄像头
        VideoCaptureDevice videoSource;//视频拍摄设置
        StaffService staffServicer = new StaffService();
        PostService postService = new PostService();
        public FrmAddStaff()
        {
            InitializeComponent();
            this.cmbPost.DataSource=postService.GetPosts();
            this.cmbPost.DisplayMember = "PostName";
            this.cmbPost.ValueMember = "PostId";
        }
        #region 添加学生
        private void btnAddstaff_Click(object sender, EventArgs e)
        {
            if (this.txtStaffName.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入姓名","信息提示");
                return;
            }
            if (this.txtPhone.Text.Trim().Length == 0&& !Regex.IsMatch(this.txtPhone.Text.Trim(), "^[0-9]*$"))
            {
                MessageBox.Show("请输入正确电话号码", "信息提示");
                return;
            }
            Staff staff = new Staff() {
                StaffName = this.txtStaffName.Text.Trim(),
                Grender = this.rdoMale.Checked == true ? "男" : "女",
                Phone = this.txtPhone.Text.Trim(),
                JobNum = this.txtJobNum.Text.Trim(),
                StaffAddress =this. txtAddress.Text.Trim(),
                Birthday=this.dtpBirthday.Value,
                StaffIamage = this.picPhoto.ImageLocation==null?"": GetFileName(this.picPhoto.ImageLocation),
                Age = GetAge(this.dtpBirthday.Value),
                DepartmentId =Convert.ToInt32 (this.cmbDepartment.SelectedValue),
                PostId = Convert.ToInt32(this.cmbPost.SelectedValue),
                EducationId = Convert.ToInt32(this.cmbEducation.SelectedValue),
                IdentityNum = this.txtIdentity.Text.Trim(),
            };
            bool result = staffServicer.AddStaff(staff);
            if (result)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
        private  int GetAge(DateTime birthday)
        {
            int age = 0;
            DateTime today = DateTime.Today;
            age = today.Year - birthday.Year;
            if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }
        #endregion
        #region 摄像头
        private void btnStartVideo_Click(object sender, EventArgs e)//启动摄像头
        {
            videoDevices= new FilterInfoCollection(FilterCategory.VideoInputDevice);//获取摄像头设备
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);//创建视频源
            this.picVideoSourcePlayer.VideoSource = videoSource;//将摄像头视频源赋给视频播放控件
            this.picVideoSourcePlayer.Start();//启动摄像头
        }
        private void btnClosevideo_Click(object sender, EventArgs e)
        {
            this.picVideoSourcePlayer.SignalToStop();
        }
        private void btnTakePhotos_Click(object sender, EventArgs e)
        {
            if (!this.picVideoSourcePlayer.IsRunning)
            {
                MessageBox.Show("请先启动摄像头","信息提示",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!Directory.Exists("Image"))
            {
                Directory.CreateDirectory("Image");
            }
            string fileName=Directory.GetCurrentDirectory() + "\\Image\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            Bitmap bitmap = this.picVideoSourcePlayer.GetCurrentVideoFrame();
            bitmap.Save(fileName);//获取图片并保存
            this.picPhoto.Image = bitmap;//显示图片
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            this.picPhoto.Image = null;
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Image"))
            {
                Directory.CreateDirectory("Image");
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string oldFileName = openFileDialog.FileName;
                string newFileName = Directory.GetCurrentDirectory() + "\\Image\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                FileInfo fileInfo = new FileInfo(oldFileName);
                fileInfo.CopyTo(newFileName);
                this.picPhoto.ImageLocation = newFileName;
            }
        }
#endregion
        private string GetFileName(string filePath)
        {
            string[] stringArray=filePath.Split('\\');
            return stringArray[stringArray.Length - 1];
        }
    }
}
