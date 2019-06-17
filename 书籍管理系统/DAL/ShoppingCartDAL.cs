using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class ShoppingCartDAL
    {
        private static string cmdText;
        public static int Delete(string isbn)
        {
            cmdText = "delete from Cart where ID='" + isbn + "'";
            return DBHelp.ExecuteNonQuery(cmdText);
        }

        public static int Add(string isbn)
        {
            cmdText = "";
            return DBHelp.ExecuteNonQuery(cmdText);
        }
    }
}
