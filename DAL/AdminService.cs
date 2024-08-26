using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public SysAdmin GetSysAdmin(SysAdmin admin)
        {
            string sqlstring =$"select AdminName, LoginId,LoginPwd from SysAdmin where LoginId='{admin.LoginId}' and LoginPwd='{admin.LoginPwd}'";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sqlstring, conn);
            //conn.Open();
            //SqlDataReader reader=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sqlstring);
            SysAdmin Admin =new SysAdmin();
            if (reader.Read())
            {
                Admin.AdminName = reader["AdminName"].ToString();
                reader.Close();
            }
            return Admin;
        }
    }
}
