using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

public partial class BookMin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string bookName = Request.QueryString["BookName"];
        List<BookInfo> lstAllBooks = BookInfoBLL.FinfAllBooks();
        lstAllBooks=lstAllBooks.FindAll(book=>book.BookName.ToLower().Contains(bookName.ToLower()));
        Repeater1.DataSource = lstAllBooks;
        Repeater1.DataBind();
    }
}