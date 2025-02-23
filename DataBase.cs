using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satelliteeducationsystem
{
    public static class DataBase
    {
        private static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Learning_Platform;Integrated Security=True");
        public static DataSet QueryLots(string sql, string TableName)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds, TableName);
            return ds;
        }
        public static bool ExcuteSql(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            int num = cmd.ExecuteNonQuery();
            conn.Close();
            return num > 0;
        }
        public static object QuerySingle(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            object o = cmd.ExecuteScalar();
            conn.Close();
            return o;
        }
    }
}
