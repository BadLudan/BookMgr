using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class UsrInfo
    {
        private string usrName;

        public string UsrName
        {
            get { return usrName; }
            set { usrName = value; }
        }
        private string usrPwd;

        public string UsrPwd
        {
            get { return usrPwd; }
            set { usrPwd = value; }
        }
        private string usrEmail;

        public string UsrEmail
        {
            get { return usrEmail; }
            set { usrEmail = value; }
        }
    }
}
