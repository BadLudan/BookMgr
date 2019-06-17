using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelp
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private static SqlConnection connection;

        private static SqlConnection Connection
        {
            get {
                connection = new SqlConnection(connectionString);
                return DBHelp.connection;
                
            }
           
        }
        public static int ExecuteNonQuery(String cmdText)
        {

            SqlCommand cmd = new SqlCommand(cmdText, Connection);


            Connection.Open(); 
            cmd.Connection.Open(); //12345
            int result = cmd.ExecuteNonQuery();

            cmd.Dispose();
            Close();

            return result;

        }

        private static void Close()
        {
            if (Connection != null)
            {
                Connection.Close();
                Connection.Dispose();
            }
        }

        public static int ExecuteNonQuery(String cmdText, SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(cmdText, Connection);
            cmd.Parameters.AddRange(values); 
            connection.Open();
            int result = cmd.ExecuteNonQuery();

            cmd.Dispose();
            Close();

            return result;

        }

        public static DataSet GetDataSet(string cmdText)
        {
            SqlCommand cmd = new SqlCommand(cmdText, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            Close();
            return ds;

        }

        public static DataSet GetDataSet(string cmdText, SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(cmdText, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            Close();
            return ds;

        }


    }
}
