using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class EducationService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public List<StaffEducation> GetEducation()
        {
            string sql = "SELECT EducationId,EducationName FROM StaffEducation";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<StaffEducation> list = new List<StaffEducation>();
            while (reader.Read())
            {
                StaffEducation education = new StaffEducation()
                {
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    EducationName = reader["EducationName"].ToString(),
                };
                list.Add(education);
            }
            reader.Close();
            return list;
        }
    }
}
