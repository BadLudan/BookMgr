using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ShoppingCartBLL
    {
        public static int result;
        public static bool DeleteBook(string isbn)
        {
            result = ShoppingCartDAL.Delete(isbn);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
