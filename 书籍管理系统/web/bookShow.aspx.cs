using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

public partial class bookShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sort = Request.QueryString["Sort"];
        List<BookInfo> lstBooks = BookInfoBLL.FinfAllBooksBT(sort);
        dlstShowBook.DataSource = lstBooks;
        dlstShowBook.DataBind();

    }
    protected void dlstShowBook_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void dlstShowBook_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("describe"))
        {
            Response.Redirect("BookMin.aspx?BookName="+e.CommandArgument.ToString());
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton LinkButton2 = (LinkButton)sender;
        Label bookName = (Label)LinkButton2.Parent.FindControl("Label1");

        BookInfo book = new BookInfo();
        book.BookName = bookName.Text;
        RegisterStartupScript("key", "<script type='text/javascript'>alert('购买成功');</script>");
        BookInfoBLL.AddBook(book, 1); //1用于购物车

    }
}