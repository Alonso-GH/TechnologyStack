using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public bool AddStaff(Staff staff)
        {
            string sqlstring = $"INSERT INTO dbo.Staff(StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,DepartmentId,PostId,EducationId,IdentityNum)" +
                $"VALUES('{staff.StaffName}','{staff.Grender}','{staff.Birthday}','{staff.JobNum}','{staff.StaffIamage}','{staff.Age}','{staff.Phone}','{staff.StaffAddress}','{staff.Department}','{staff.Post}','{staff.Education}','{staff.IdentityNum}')";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sqlstring, conn);
            //conn.Open();
            //int result = cmd.ExecuteNonQuery();
            //conn.Close();
            //return result;
            return SQLHelper.ExecuteNonQuery(sqlstring);
        }
        public List<Staff> GetAllStaff()
        {
            string sql = $"SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                $"EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public Staff GetStaffDetail(string JobNum)
        {
            string sql = $"SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                $"EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId" +
                $" INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId WHERE JobNum = '{JobNum}'";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            Staff staff = new Staff();
            if (reader.Read())
            {
                staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
            }
            reader.Close();
            return staff;
        }
        public List<Staff> GetStaffListByJobNum(string JobNum)
        {
            string sql = "SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                "EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId where JobNum LIKE '%{JobNum}%'";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public List<Staff> GetStaffListByStaffName(string staffName)
        {
            string sql = "SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                "EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId where StaffName LIKE '%{staffName}%'";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public List<Staff> GetStaffListByDepartmentId(string departmentId)
        {
            string sql = "SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                "EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId where Staff.DepartmentId = {departmentId}";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public List<Staff> GetStaffListByEducationId(string educationId)
        {
            string sql = "SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                "EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId where Staff.EducationId = {educationId}";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public List<Staff> GetStaffListByPostId(string postId)
        {
            string sql = "SELECT StaffName,Grender,Birthday,JobNum,StaffIamage,Age,Phone,StaffAddress,IdentityNum,DepartmentName,Staff.DepartmentId,Staff.EducationId,Staff.PostId," +
                "EducationName,PostName FROM dbo.Staff INNER JOIN dbo.StaffDepartment ON StaffDepartment.DepartmentId = Staff.DepartmentId " +
                $"INNER JOIN dbo.StaffEducation ON StaffEducation.EducationId = Staff.EducationId INNER JOIN dbo.StaffPost ON StaffPost.PostId = Staff.PostId where Staff.PostId = {postId}";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(behavior: System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<Staff> stafflist = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff()
                {
                    StaffName = reader["StaffName"].ToString(),
                    Grender = reader["Grender"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    JobNum = reader["JobNum"].ToString(),
                    StaffIamage = reader["StaffIamage"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Phone = reader["Phone"].ToString(),
                    StaffAddress = reader["StaffAddress"].ToString(),
                    IdentityNum = reader["IdentityNum"].ToString(),
                    Department = reader["DepartmentName"].ToString(),
                    Education = reader["EducationName"].ToString(),
                    Post = reader["PostName"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    EducationId = Convert.ToInt32(reader["EducationId"]),
                    PostId = Convert.ToInt32(reader["PostId"]),
                };
                stafflist.Add(staff);
            }
            reader.Close();
            return stafflist;
        }
        public bool UpdateStaffInfo(Staff staff)
        {
            //using (SqlConnection conn = new SqlConnection(connString)) {
                string sql = $"UPDATE Staff SET StaffName='{staff.StaffName}',Grender='{staff.Grender}',Birthday='{staff.Birthday}'," +
                    $"StaffIamage='{staff.StaffIamage}',Age={staff.Age},Phone='{staff.Phone}',StaffAddress='{staff.StaffAddress}',DepartmentId={staff.DepartmentId}," +
                    $"PostId={staff.PostId},EducationId={staff.EducationId},IdentityNum='{staff.IdentityNum}' WHERE JobNum='{staff.JobNum}'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //conn.Open();
                //int result=cmd.ExecuteNonQuery();
                //conn.Close();
                //if (result > 0)return true;
                //else return false;
                return SQLHelper.ExecuteNonQuery(sql);
            //}
        }  
        public bool DeleteStaffInfo(string JobNum)
        {
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
                string sql = $"DELETE FROM dbo.Staff WHERE JobNum='{JobNum}'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    int result = cmd.ExecuteNonQuery();
            //    conn.Close();
            //    if (result > 0) return true;
            //    else return false;
            //}
            return SQLHelper.ExecuteNonQuery(sql);
        }
    }
}

