using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLHelper
    {
        private static readonly string connString = "Password=025423;Persist Security Info=True;User ID=jm025423;Initial Catalog=ABC;Data Source=192.168.231.10";
        public static bool ExecuteNonQuery(string sql)
        {///增删改
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int reuslt = cmd.ExecuteNonQuery();
                if (reuslt > 0) return true;
                else return false;
            }
        }
        public static SqlDataReader ExecuteReader(string sql)
        {//批量查询
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static object ExecuteScalar(string sql)
        {//标量查询
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
        public static bool UpdateByTransaction(List<string> sqlList)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    foreach (string sql in sqlList)
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw new Exception("调用UpdateByTransaction失败!" + ex.Message);
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
                    conn.Close();
                }
            }
        }
    }
}
