using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class BookInfoBLL
    {
        public static int result;

        public static List<BookInfo> FinfAllBooks()
       {
           List<BookInfo> lstBooks = BookInfoDAL.Select();
           return lstBooks;
       }

        public static List<BookInfo> FinfAllBooks(int z)
        {
            List<BookInfo> lstBooks = BookInfoDAL.Select(z);
            return lstBooks;
        }

        public static List<BookInfo> FinfAllBooksBT(string sort)
        {
            List<BookInfo> lstBooks = BookInfoDAL.Select(sort);
            return lstBooks;
        }
        public static List<BookInfo> FinfAllBooksIndent(Boolean a)
        {
            List<BookInfo> lstBooks = BookInfoDAL.Select(a);
            return lstBooks;
        }

        public static bool DeleteBook(string isbn)
        {
            result = BookInfoDAL.Delete(isbn);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool DeleteIndent(string id)
        {
            result = BookInfoDAL.DeleteIndent(id);
            if (result > 0)
            {
                return true;


            }
            else
                return false;
        }

        public static bool UpdateBook(BookInfo book)
        {
            result = BookInfoDAL.Update(book);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool AddBook (BookInfo book, int z)
        {
            result = BookInfoDAL.Add(book, z);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool AddBookToIndent(string id,int num)
        {
            result = BookInfoDAL.AddToIndent(id,num);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
