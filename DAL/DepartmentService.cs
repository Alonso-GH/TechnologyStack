using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class DepartmentService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public List<StaffDepartment> GetDepartment()
        {
            string sql = "SELECT DepartmentId,DepartmentName FROM StaffDepartment";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<StaffDepartment> departmentlist = new List<StaffDepartment>();
            while (reader.Read())
            {
                StaffDepartment department = new StaffDepartment()
                {
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    DepartmentName = reader["DepartmentName"].ToString(),
                };
                departmentlist.Add(department);
            }
            reader.Close();
            return departmentlist;
        }
    }
}
