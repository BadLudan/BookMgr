using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UsrInfoDAL
    {
        public static int Insert(UsrInfo user)
        {            
            String cmdText = "insert into UsrInfo(usrName,usrPwd,usrEmail) values(@usrName,@usrPwd,@usrEmail)";
            SqlParameter[] values = new SqlParameter[3];
            values[0] = new SqlParameter("usrName", user.UsrName);
            values[1] = new SqlParameter("usrPwd", user.UsrPwd);
            values[2] = new SqlParameter("usrEmail", user.UsrEmail);


            int result = DBHelp.ExecuteNonQuery(cmdText, values);

            
            return result;

        }

        public static UsrInfo Select(string usrName)
        {
            string cmdText = "select * from UsrInfo where usrName='" + usrName + "'";
            DataSet ds=DBHelp.GetDataSet(cmdText);

           

            UsrInfo user =null;
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                user = new UsrInfo();
                DataRow dr = dt.Rows[0];
                user.UsrEmail = dr["usrEmail"].ToString();
                user.UsrName = dr["usrName"].ToString();
                user.UsrPwd = dr["usrPwd"].ToString();

            }
            return user;
        }
    }
}
