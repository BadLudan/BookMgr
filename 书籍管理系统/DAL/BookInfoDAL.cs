using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
   public class BookInfoDAL
    {
       private static string cmdText;

       public static List<BookInfo> Select()
       {
           cmdText = "select * from BookInfo";
           DataSet ds = DBHelp.GetDataSet(cmdText);
           DataTable dt = ds.Tables[0];
           List<BookInfo> lstBooks = new List<BookInfo>();
           if (dt.Rows.Count > 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   BookInfo book = new BookInfo();
                   
                   book.isbn = Convert.ToInt32(dr["ISBN"]);
                   book.Price = Convert.ToInt32(dr["price"]);
                   book.CountIn = Convert.ToInt32(dr["countIn"]);
                   book.CountOut = Convert.ToInt32(dr["countOut"]);
                   book.BookName = dr["bookName"].ToString();
                   book.BookAuthor = dr["bookAuthor"].ToString();
                   book.BookAbout = dr["bookAbout"].ToString();
                   book.BookType = dr["bookType"].ToString();
                   book.image = dr["Image"].ToString();
                   lstBooks.Add(book);
               }
 
           }
           return lstBooks;
       }

        public static List<BookInfo> Select(Boolean a)
        {
            cmdText = "select * from Indent";
            DataSet ds = DBHelp.GetDataSet(cmdText);
            DataTable dt = ds.Tables[0];
            List<BookInfo> lstBooks = new List<BookInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BookInfo book = new BookInfo();
                    book.id = Convert.ToInt32(dr["ID"]);
                    book.isbn = Convert.ToInt32(dr["ISBN"]);
                    book.Price = Convert.ToInt32(dr["price"]);
                    book.CountIn = Convert.ToInt32(dr["countIn"]);
                    book.CountOut = Convert.ToInt32(dr["countOut"]);
                    book.BookName = dr["bookName"].ToString();
                    book.BookAuthor = dr["bookAuthor"].ToString();
                    book.BookAbout = dr["bookAbout"].ToString();
                    book.BookType = dr["bookType"].ToString();
                    book.image = dr["Image"].ToString();
                    book.Number = Convert.ToInt32(dr["Number"]);
                    lstBooks.Add(book);
                }

            }
            return lstBooks;
        }

        public static int Delete(string isbn)
       {
           cmdText="delete from BookInfo where ISBN='"+ isbn +"'";
           return DBHelp.ExecuteNonQuery(cmdText);
       }

        public static int DeleteIndent(string id)
        {
            cmdText = "delete from Indent where ID='" + id + "'";
            return DBHelp.ExecuteNonQuery(cmdText);
        }
        public static List<BookInfo> Select(string sort)
       {
           cmdText = "select * from BookInfo where BookType=N'"+ sort +"'";
           DataSet ds = DBHelp.GetDataSet(cmdText);
           DataTable dt = ds.Tables[0];
           List<BookInfo> lstBooks = new List<BookInfo>();
           if (dt.Rows.Count > 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   BookInfo book = new BookInfo();
                    
                    book.isbn = Convert.ToInt32(dr["ISBN"]);
                   book.Price = Convert.ToInt32(dr["price"]);
                   book.CountIn = Convert.ToInt32(dr["countIn"]);
                   book.CountOut = Convert.ToInt32(dr["countOut"]);
                   book.BookName = dr["bookName"].ToString();
                   book.BookAuthor = dr["bookAuthor"].ToString();
                   book.BookAbout = dr["bookAbout"].ToString();
                   book.BookType = dr["bookType"].ToString();
                   book.image = dr["Image"].ToString();
                   lstBooks.Add(book);
               }

           }
           return lstBooks;
       }
        

       public static List<BookInfo> Select(int z)
       {
           if (z==1)            cmdText = "select * from Cart"; //购物车
           DataSet ds = DBHelp.GetDataSet(cmdText);
           DataTable dt = ds.Tables[0];
           List<BookInfo> lstBooks = new List<BookInfo>();
           if (dt.Rows.Count > 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   BookInfo book = new BookInfo();
                    book.id = Convert.ToInt32(dr["ID"]);
                    book.isbn = Convert.ToInt32(dr["ISBN"]);
                   book.Price = Convert.ToInt32(dr["price"]);
                   book.CountIn = Convert.ToInt32(dr["countIn"]);
                   book.CountOut = Convert.ToInt32(dr["countOut"]);
                   book.BookName = dr["bookName"].ToString();
                   book.BookAuthor = dr["bookAuthor"].ToString();
                   book.BookAbout = dr["bookAbout"].ToString();
                   book.BookType = dr["bookType"].ToString();
                   book.image = dr["Image"].ToString();
                   lstBooks.Add(book);
               }

           }
           return lstBooks;
       }

       public static int Update(BookInfo book)
       {
           cmdText = "update BookInfo set bookName=@bookName,bookAuthor=@bookAuthor,price=@price,countIn=@countIn,countOut=@countOut,bookAbout=@bookAbout,bookType=@bookType where ISBN=@ISBN"; 
           SqlParameter[] values=new SqlParameter[8];
           values[0]=new SqlParameter("bookName",book.BookName);
           values[1]=new SqlParameter("bookAuthor",book.BookAuthor);
           values[2]=new SqlParameter("price",book.Price);
           values[3]=new SqlParameter("countIn",book.CountIn);
           values[4]=new SqlParameter("countOut",book.CountOut);
           values[5]=new SqlParameter("bookAbout",book.BookAbout);
           values[6]=new SqlParameter("bookType",book.BookType);
           values[7]=new SqlParameter("ISBN",book.isbn);
          return DBHelp.ExecuteNonQuery(cmdText, values);
       }


       public static int Add(BookInfo book, int z)
       {
           if (z == 1) cmdText = "insert into Cart(bookName,bookAuthor,ISBN,price,countIn,countOut,bookAbout,bookType,Image) select bookName,bookAuthor,ISBN,price,countIn,countOut,bookAbout,bookType,Image from BookInfo where bookName=N'" + book.BookName + "'";

           return DBHelp.ExecuteNonQuery(cmdText);
       }


        public static int AddToIndent(string id,int num)
        {
            cmdText = "insert into Indent(ID,bookName,bookAuthor,ISBN,price,countIn,countOut,bookAbout,bookType,Image,number) select ID,bookName,bookAuthor,ISBN,price,countIn,countOut,bookAbout,bookType,Image,"+ num +" from Cart where id='"+ id +"'";

            return DBHelp.ExecuteNonQuery(cmdText);
        }

    }
}
