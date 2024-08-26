using DAL;
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
    public partial class CustomManager : Form
    {
        CustomService customService=new CustomService();
        public CustomManager()
        {
            InitializeComponent();
            this.dgvCustomList.AutoGenerateColumns = false;
            this.dgvCustomList.DataSource = customService.GetCustomLists("", "", "", "");

            this.cmbPartnerType.DataSource = customService.GetPartnerType();
            this.cmbPartnerType.DisplayMember = "PartnerType"; this.cmbPartnerType.ValueMember = "PartnerType";
            this.cmbPartnerType.SelectedIndex = -1;

            Dictionary <string,string> dic=customService.GetPartnerTypeInfo();
            this.txtCustomerNum.Text = dic["customerNum"];
            this.txtSupplierNum.Text = dic["supplierNum"];

            this.listBoxStaffName.Items.AddRange(customService.GerSalesList().ToArray());
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string customName=this.txtCustomName.Text.Trim();
            string jobNum=this.txtJobNum.Text.Trim();
            string partnerID = this.txtPartnerID.Text.Trim();
            string partnerType = (this.cmbPartnerType.SelectedValue).ToString();
            this.dgvCustomList.DataSource = customService.GetCustomLists(customName, partnerID, partnerType, partnerID);
        }
    }
}
