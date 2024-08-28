using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helper
{
    public class ImportExcel
    {
        /// <summary>
        /// 读取Excel中的数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static List<Staff> GetStaffByExcel(string path)
        {
            List<Staff> staffList = new List<Staff>();
            DataSet ds = OleDbHelper.GetDataSet( "SELECT * FROM [Sheet1$]", path);
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff()
                {  JobNum= row["JobNum"].ToString(),
                    StaffName = row["StaffName"].ToString(),
                    Grender = row["Grender"].ToString(),
                    Birthday =Convert.ToDateTime( row["Birthday"]),
                    Phone = row["Phone"].ToString(),
                    DepartmentId = Convert.ToInt32(row["DepartmentId"]),
                    PostId = Convert.ToInt32(row["PostId"]),
                    EducationId = Convert.ToInt32(row["EducationId"]),
                    IdentityNum= row["IdentityNum"].ToString(),
                    StaffAddress = row["StaffAddress"].ToString(),
                };
                staffList.Add(staff);
            }
            return staffList;
        }
    }
}
