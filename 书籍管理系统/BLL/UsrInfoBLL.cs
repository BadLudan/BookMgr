using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UsrInfoBLL
    {
        public static bool AddUser(UsrInfo user)
        {
            int result=UsrInfoDAL.Insert(user);
            if (result > 0)
                return true;
            else
                return false;
        }



        public static bool login(string usrName, string usrPwd)
        {

            UsrInfo user = UsrInfoDAL.Select(usrName);
            if (user == null)
            {
                return false;
            }
            else
                if (user.UsrPwd.Equals(usrPwd))
                {
                    return true;
                }
                else
                    return false;
        }
    }
}
