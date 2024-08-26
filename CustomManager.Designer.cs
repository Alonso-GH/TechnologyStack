namespace ERPManagerSYS
{
    partial class CustomManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtJobNum = new System.Windows.Forms.TextBox();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.txtPartnerID = new System.Windows.Forms.TextBox();
            this.cmbPartnerType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.客户编号 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.统计 = new System.Windows.Forms.GroupBox();
            this.txtSupplierNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxStaffName = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomList = new System.Windows.Forms.DataGridView();
            this.PartnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.统计.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtJobNum);
            this.groupBox1.Controls.Add(this.txtCustomName);
            this.groupBox1.Controls.Add(this.txtPartnerID);
            this.groupBox1.Controls.Add(this.cmbPartnerType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.客户编号);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(747, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(58, 26);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtJobNum
            // 
            this.txtJobNum.Location = new System.Drawing.Point(641, 15);
            this.txtJobNum.Name = "txtJobNum";
            this.txtJobNum.Size = new System.Drawing.Size(100, 21);
            this.txtJobNum.TabIndex = 4;
            // 
            // txtCustomName
            // 
            this.txtCustomName.Location = new System.Drawing.Point(65, 17);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(121, 21);
            this.txtCustomName.TabIndex = 9;
            // 
            // txtPartnerID
            // 
            this.txtPartnerID.Location = new System.Drawing.Point(269, 17);
            this.txtPartnerID.Name = "txtPartnerID";
            this.txtPartnerID.Size = new System.Drawing.Size(100, 21);
            this.txtPartnerID.TabIndex = 8;
            // 
            // cmbPartnerType
            // 
            this.cmbPartnerType.FormattingEnabled = true;
            this.cmbPartnerType.Location = new System.Drawing.Point(437, 16);
            this.cmbPartnerType.Name = "cmbPartnerType";
            this.cmbPartnerType.Size = new System.Drawing.Size(121, 20);
            this.cmbPartnerType.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "客户类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "跟进人工号";
            // 
            // 客户编号
            // 
            this.客户编号.AutoSize = true;
            this.客户编号.Location = new System.Drawing.Point(210, 21);
            this.客户编号.Name = "客户编号";
            this.客户编号.Size = new System.Drawing.Size(53, 12);
            this.客户编号.TabIndex = 5;
            this.客户编号.Text = "客户编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "客户名字";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(834, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "打印";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 统计
            // 
            this.统计.Controls.Add(this.txtSupplierNum);
            this.统计.Controls.Add(this.label5);
            this.统计.Controls.Add(this.listBoxStaffName);
            this.统计.Controls.Add(this.label7);
            this.统计.Controls.Add(this.txtCustomerNum);
            this.统计.Controls.Add(this.label2);
            this.统计.Location = new System.Drawing.Point(878, 77);
            this.统计.Name = "统计";
            this.统计.Size = new System.Drawing.Size(159, 608);
            this.统计.TabIndex = 2;
            this.统计.TabStop = false;
            this.统计.Text = "统计";
            // 
            // txtSupplierNum
            // 
            this.txtSupplierNum.Location = new System.Drawing.Point(26, 94);
            this.txtSupplierNum.Name = "txtSupplierNum";
            this.txtSupplierNum.Size = new System.Drawing.Size(100, 21);
            this.txtSupplierNum.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "销售人员名单：";
            // 
            // listBoxStaffName
            // 
            this.listBoxStaffName.FormattingEnabled = true;
            this.listBoxStaffName.ItemHeight = 12;
            this.listBoxStaffName.Location = new System.Drawing.Point(18, 147);
            this.listBoxStaffName.Name = "listBoxStaffName";
            this.listBoxStaffName.Size = new System.Drawing.Size(123, 460);
            this.listBoxStaffName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "供应商人数：";
            // 
            // txtCustomerNum
            // 
            this.txtCustomerNum.Location = new System.Drawing.Point(26, 38);
            this.txtCustomerNum.Name = "txtCustomerNum";
            this.txtCustomerNum.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerNum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "客户人数:";
            // 
            // dgvCustomList
            // 
            this.dgvCustomList.AllowUserToAddRows = false;
            this.dgvCustomList.AllowUserToDeleteRows = false;
            this.dgvCustomList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartnerID,
            this.CustomName,
            this.PartnerType,
            this.JobNum});
            this.dgvCustomList.Location = new System.Drawing.Point(12, 69);
            this.dgvCustomList.Name = "dgvCustomList";
            this.dgvCustomList.ReadOnly = true;
            this.dgvCustomList.RowTemplate.Height = 23;
            this.dgvCustomList.Size = new System.Drawing.Size(860, 616);
            this.dgvCustomList.TabIndex = 3;
            // 
            // PartnerID
            // 
            this.PartnerID.DataPropertyName = "PartnerID";
            this.PartnerID.HeaderText = "客户编号";
            this.PartnerID.Name = "PartnerID";
            this.PartnerID.ReadOnly = true;
            // 
            // CustomName
            // 
            this.CustomName.DataPropertyName = "CustomName";
            this.CustomName.HeaderText = "客户名称";
            this.CustomName.Name = "CustomName";
            this.CustomName.ReadOnly = true;
            // 
            // PartnerType
            // 
            this.PartnerType.DataPropertyName = "PartnerType";
            this.PartnerType.HeaderText = "客户类型";
            this.PartnerType.Name = "PartnerType";
            this.PartnerType.ReadOnly = true;
            // 
            // JobNum
            // 
            this.JobNum.DataPropertyName = "JobNum";
            this.JobNum.HeaderText = "订单跟进人";
            this.JobNum.Name = "JobNum";
            this.JobNum.ReadOnly = true;
            // 
            // CustomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 697);
            this.Controls.Add(this.dgvCustomList);
            this.Controls.Add(this.统计);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomManager";
            this.Text = "客户列表";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.统计.ResumeLayout(false);
            this.统计.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPartnerType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox 统计;
        private System.Windows.Forms.DataGridView dgvCustomList;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtJobNum;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.TextBox txtPartnerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 客户编号;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxStaffName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobNum;
    }
}