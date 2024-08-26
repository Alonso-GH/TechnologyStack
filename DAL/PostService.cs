using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class PostService
    {
        //private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public List<StaffPost> GetPosts()
        {
            string sql = "SELECT PostId,PostName FROM StaffPost";
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            List<StaffPost> postslist = new List<StaffPost>();
            while (reader.Read())
            {
                StaffPost staffposts=new StaffPost()
                {
                    PostId = (int)reader["PostID"],
                    PostName = reader["PostName"].ToString(),
                };
                postslist.Add(staffposts);
            }
            reader.Close();
            return postslist;
        }
    }
}
