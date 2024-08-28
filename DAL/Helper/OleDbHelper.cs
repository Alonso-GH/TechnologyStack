using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OleDbHelper
    {
        private static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0";
        //private static string connAccess=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=False;";
        public static DataSet GetDataSet(string sql, string path)
        {
            OleDbConnection conn = new OleDbConnection(string.Format(connString, path));
            OleDbCommand cmd = new OleDbCommand(sql,conn);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            try{
                 conn.Open();
                oleDbDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
        public static bool ExecuteNonQuery(string sql)
        {///增删改
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                int reuslt = cmd.ExecuteNonQuery();
                if (reuslt > 0) return true;
                else return false;
            }
        }
        public static OleDbDataReader ExecuteReader(string sql)
        {//批量查询
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static object ExecuteScalar(string sql)
        {//标量查询
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
        public static bool UpdateByTransaction(List<string> sqlList)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                OleDbTransaction transaction = null;
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
