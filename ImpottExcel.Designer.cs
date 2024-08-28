namespace ERPManagerSYS
{
    partial class ImpottExcel
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
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.bynAddToBatabase = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.JobNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToDeleteRows = false;
            this.dgvStaffList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobNum,
            this.StaffName,
            this.Grender,
            this.Birthday,
            this.Age,
            this.Phone,
            this.Department,
            this.Post,
            this.Education,
            this.IdentityNum,
            this.StaffAddress});
            this.dgvStaffList.Location = new System.Drawing.Point(12, 86);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.RowTemplate.Height = 23;
            this.dgvStaffList.Size = new System.Drawing.Size(1023, 585);
            this.dgvStaffList.TabIndex = 2;
            // 
            // bynAddToBatabase
            // 
            this.bynAddToBatabase.Location = new System.Drawing.Point(881, 12);
            this.bynAddToBatabase.Name = "bynAddToBatabase";
            this.bynAddToBatabase.Size = new System.Drawing.Size(116, 55);
            this.bynAddToBatabase.TabIndex = 3;
            this.bynAddToBatabase.Text = "添加到数据库";
            this.bynAddToBatabase.UseVisualStyleBackColor = true;
            this.bynAddToBatabase.Click += new System.EventHandler(this.bynAddToBatabase_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(727, 12);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(116, 55);
            this.btnImportExcel.TabIndex = 4;
            this.btnImportExcel.Text = "导入Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // JobNum
            // 
            this.JobNum.DataPropertyName = "JobNum";
            this.JobNum.HeaderText = "工号";
            this.JobNum.Name = "JobNum";
            this.JobNum.ReadOnly = true;
            this.JobNum.Width = 70;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "姓名";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // Grender
            // 
            this.Grender.DataPropertyName = "Grender";
            this.Grender.HeaderText = "性别";
            this.Grender.Name = "Grender";
            this.Grender.ReadOnly = true;
            this.Grender.Width = 60;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "生日";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 60;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "部门";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.DataPropertyName = "Post";
            this.Post.HeaderText = "职位";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 60;
            // 
            // Education
            // 
            this.Education.DataPropertyName = "Education";
            this.Education.HeaderText = "学历";
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.Width = 60;
            // 
            // IdentityNum
            // 
            this.IdentityNum.HeaderText = "身份证";
            this.IdentityNum.Name = "IdentityNum";
            this.IdentityNum.ReadOnly = true;
            // 
            // StaffAddress
            // 
            this.StaffAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffAddress.HeaderText = "地址";
            this.StaffAddress.Name = "StaffAddress";
            this.StaffAddress.ReadOnly = true;
            // 
            // ImpottExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 697);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.bynAddToBatabase);
            this.Controls.Add(this.dgvStaffList);
            this.Name = "ImpottExcel";
            this.Text = "ImpottExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Button bynAddToBatabase;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffAddress;
    }
}