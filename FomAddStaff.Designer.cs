namespace ERPManagerSYS
{
    partial class FrmAddStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.btnClosevideo = new System.Windows.Forms.Button();
            this.btnTakePhotos = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddstaff = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJobNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frm = new System.Windows.Forms.DataGridView();
            this.picVideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartVideo.Location = new System.Drawing.Point(406, 31);
            this.btnStartVideo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(89, 46);
            this.btnStartVideo.TabIndex = 2;
            this.btnStartVideo.Text = "启动摄像头";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // btnClosevideo
            // 
            this.btnClosevideo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosevideo.Location = new System.Drawing.Point(583, 31);
            this.btnClosevideo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClosevideo.Name = "btnClosevideo";
            this.btnClosevideo.Size = new System.Drawing.Size(89, 46);
            this.btnClosevideo.TabIndex = 3;
            this.btnClosevideo.Text = "关闭摄像头";
            this.btnClosevideo.UseVisualStyleBackColor = true;
            this.btnClosevideo.Click += new System.EventHandler(this.btnClosevideo_Click);
            // 
            // btnTakePhotos
            // 
            this.btnTakePhotos.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTakePhotos.Location = new System.Drawing.Point(406, 117);
            this.btnTakePhotos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTakePhotos.Name = "btnTakePhotos";
            this.btnTakePhotos.Size = new System.Drawing.Size(89, 46);
            this.btnTakePhotos.TabIndex = 4;
            this.btnTakePhotos.Text = "开始拍照";
            this.btnTakePhotos.UseVisualStyleBackColor = true;
            this.btnTakePhotos.Click += new System.EventHandler(this.btnTakePhotos_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearPhoto.Location = new System.Drawing.Point(583, 117);
            this.btnClearPhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(89, 46);
            this.btnClearPhoto.TabIndex = 5;
            this.btnClearPhoto.Text = "删除照片";
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectPhoto.Location = new System.Drawing.Point(406, 219);
            this.btnSelectPhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(89, 46);
            this.btnSelectPhoto.TabIndex = 6;
            this.btnSelectPhoto.Text = "选择照片";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(725, 12);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(218, 299);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPhoto.TabIndex = 1;
            this.picPhoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddstaff);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmbPost);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbEducation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtJobNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdentity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // btnAddstaff
            // 
            this.btnAddstaff.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddstaff.Location = new System.Drawing.Point(926, 117);
            this.btnAddstaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddstaff.Name = "btnAddstaff";
            this.btnAddstaff.Size = new System.Drawing.Size(89, 46);
            this.btnAddstaff.TabIndex = 29;
            this.btnAddstaff.Text = "添加";
            this.btnAddstaff.UseVisualStyleBackColor = true;
            this.btnAddstaff.Click += new System.EventHandler(this.btnAddstaff_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(809, 117);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 46);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(607, 78);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(135, 30);
            this.cmbPost.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(561, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "岗位:";
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(886, 78);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(129, 30);
            this.cmbEducation.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(840, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "学历:";
            // 
            // txtJobNum
            // 
            this.txtJobNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJobNum.Location = new System.Drawing.Point(53, 38);
            this.txtJobNum.Name = "txtJobNum";
            this.txtJobNum.Size = new System.Drawing.Size(134, 26);
            this.txtJobNum.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "工号:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(340, 78);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(139, 30);
            this.cmbDepartment.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(294, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "部门:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(709, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "出生日期:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpBirthday.Location = new System.Drawing.Point(783, 37);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(232, 29);
            this.dtpBirthday.TabIndex = 15;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoFemale.Location = new System.Drawing.Point(616, 39);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(41, 24);
            this.rdoFemale.TabIndex = 14;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoMale.Location = new System.Drawing.Point(571, 39);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(41, 24);
            this.rdoMale.TabIndex = 12;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(525, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "性别:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(53, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 26);
            this.txtPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "电话:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(363, 127);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(410, 26);
            this.txtAddress.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(317, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "地址:";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdentity.Location = new System.Drawing.Point(81, 127);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(224, 26);
            this.txtIdentity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "身份证号:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStaffName.Location = new System.Drawing.Point(340, 38);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(134, 26);
            this.txtStaffName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(294, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // frm
            // 
            this.frm.AllowUserToAddRows = false;
            this.frm.AllowUserToDeleteRows = false;
            this.frm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frm.Location = new System.Drawing.Point(12, 518);
            this.frm.Name = "frm";
            this.frm.ReadOnly = true;
            this.frm.RowTemplate.Height = 23;
            this.frm.Size = new System.Drawing.Size(1031, 167);
            this.frm.TabIndex = 8;
            // 
            // picVideoSourcePlayer
            // 
            this.picVideoSourcePlayer.Location = new System.Drawing.Point(105, 12);
            this.picVideoSourcePlayer.Name = "picVideoSourcePlayer";
            this.picVideoSourcePlayer.Size = new System.Drawing.Size(230, 299);
            this.picVideoSourcePlayer.TabIndex = 9;
            this.picVideoSourcePlayer.Text = "picVideoSourcePlayer";
            this.picVideoSourcePlayer.VideoSource = null;
            // 
            // FrmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 697);
            this.Controls.Add(this.picVideoSourcePlayer);
            this.Controls.Add(this.frm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.btnTakePhotos);
            this.Controls.Add(this.btnClosevideo);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.picPhoto);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工资料";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.Button btnClosevideo;
        private System.Windows.Forms.Button btnTakePhotos;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJobNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddstaff;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView frm;
        private AForge.Controls.VideoSourcePlayer picVideoSourcePlayer;
    }
}