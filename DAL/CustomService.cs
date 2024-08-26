using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        string sql = "SELECT ID,PartnerID,CustomName,PartnerType,t_Custom.JobNum,UpdateTime,StaffName,Grender,Birthday,StaffIamage,Age,Phone,StaffAddress,Staff.DepartmentId,Staff.PostId," +
        "Staff.EducationId,IdentityNum,DepartmentName,EducationName,PostName FROM dbo.t_Custom INNER JOIN Staff ON Staff.JobNum = t_Custom.JobNum INNER JOIN dbo.StaffDepartment " +
        "ON StaffDepartment.DepartmentId = Staff.DepartmentId INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId ";
        public List<Custom> GetCustomLists(string CustomName, string PartnerID, string PartnerType, string JobNum)
        {
            if (!string.IsNullOrWhiteSpace(CustomName))
            {
                sql += $"where CustomName='{CustomName}'";
            }
            else if (!string.IsNullOrWhiteSpace(JobNum))
            {
                sql += $"where JobNum='{JobNum}'";
            }
            else if (!string.IsNullOrWhiteSpace(PartnerType))
            {
                sql += $"where PartnerType='{PartnerType}'";
            }
            else if (!string.IsNullOrWhiteSpace(PartnerID))
            {
                sql += $"where PartnerID='{PartnerID}'";
            }
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Custom> list = new List<Custom>();
            while (reader.Read())
                {
                    Custom custom = new Custom()
                    {
                        PartnerID = reader["PartnerID"].ToString(),
                        CustomName = reader["CustomName"].ToString(),
                        PartnerType = reader["PartnerType"].ToString(),
                        JobNum = reader["JobNum"].ToString(),
                        UpdateTime = Convert.ToDateTime(reader["UpdateTime"]),
                        StaffName = reader["StaffName"].ToString(),
                        Grender = reader["Grender"].ToString(),
                        Birthday = Convert.ToDateTime(reader["Birthday"]),
                        StaffIamage = reader["StaffName"].ToString(),
                        Age = Convert.ToInt32(reader["Age"]),
                        Phone = reader["Phone"].ToString(),
                        StaffAddress = reader["StaffAddress"].ToString(),
                        IdentityNum = reader["IdentityNum"].ToString(),
                        DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                        EducationId = Convert.ToInt32(reader["EducationId"]),
                        PostId = Convert.ToInt32(reader["PostId"]),
                        DepartmentName = reader["DepartmentName"].ToString(),
                        EducationName = reader["EducationName"].ToString(),
                        PostName = reader["PostName"].ToString(),
                    };
                    list.Add(custom);
                }
                reader.Close();
                return list;
            //}
        }
        public List<Custom> GetPartnerType()
        {
            string sql = "SELECT DISTINCT  PartnerType FROM DBO.t_Custom";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Custom> customlist = new List<Custom>();
            while (reader.Read())
            {
                Custom custom = new Custom()
                {
                    PartnerType = reader["PartnerType"].ToString(),
                };
                customlist.Add(custom);
            }
            reader.Close();
            return customlist;
        }
        public Dictionary<string, string> GetPartnerTypeInfo()
        {
            string sql = "SELECT customerNum=COUNT(*) FROM dbo.t_Custom WHERE PartnerType='其他客户'" +
                "SELECT supplierNum=COUNT(*) FROM dbo.t_Custom WHERE PartnerType='二级供应商'"+
                "SELECT DISTINCT Staff.StaffName FROM dbo.t_Custom LEFT JOIN dbo.Staff ON Staff.Jobnum = t_Custom.JobNum";
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            Dictionary<string, string> dic = new Dictionary<string, string>();
                if (reader.Read())
                {
                    dic.Add("customerNum", reader["customerNum"].ToString());

                }
                if (reader.NextResult())
                {
                    if (reader.Read()) { dic.Add("supplierNum", reader["supplierNum"].ToString()); }
                }
                reader.Close();
                return dic;
            //} 
        }
        public List<string> GerSalesList() {
            string sql = "SELECT DISTINCT StaffName FROM dbo.Staff WHERE Jobnum IN(SELECT Jobnum FROM t_Custom)";
            //using (SqlConnection conn = new SqlConnection(connString)){
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    SqlDataReader reader=cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader["StaffName"].ToString());
                }
                reader.Close();
                return  list;
            //}
        }
    }
}
