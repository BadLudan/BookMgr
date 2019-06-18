using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;
using System.Data.SqlClient;


public partial class ShopingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            Bind();
    }
    private void Bind()
    {
        List<BookInfo> lstBooks = BookInfoBLL.FinfAllBooks(1); //显示购物车
        GridView1.DataSource = lstBooks;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string isbn = GridView1.Rows[e.RowIndex].Cells[0].Text;
        TextBox txtBookName = GridView1.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox;
        TextBox txtbookAuthor = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;
        TextBox txtPrice = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;
        TextBox txtCountIn = GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox;
        TextBox txtCountOut = GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox;
        TextBox txtBookAbout = GridView1.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox;
        TextBox txtBookType = GridView1.Rows[e.RowIndex].Cells[7].Controls[1] as TextBox;


        BookInfo book = new BookInfo();
        book.BookName = txtBookName.Text;
        book.BookAuthor = txtbookAuthor.Text;
        book.isbn = Convert.ToInt32(isbn);
        book.Price = float.Parse(txtPrice.Text);
        book.CountIn = Convert.ToInt32(txtCountIn.Text);
        book.CountOut = Convert.ToInt32(txtCountOut.Text);
        book.BookAbout = txtBookAbout.Text;
        book.BookType = txtBookType.Text;
        bool result = BookInfoBLL.UpdateBook(book);
        if (result)
        {
            RegisterStartupScript("key", "<script type='text/javascript'>alert('更新成功');</script>");
        }
        else
            RegisterStartupScript("key", "<script type='text/javascript'>alert('更新失败');</script>");

        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            
            if (((CheckBox)GridView1.Rows[i].FindControl("cb1")).Checked==true)
            {
                string isbn = GridView1.Rows[i].Cells[1].Text;
                int numbers = Convert.ToInt32(((TextBox)GridView1.Rows[i].Cells[12].FindControl("TextBox5")).Text);
                BookInfoBLL.AddBookToIndent(isbn, numbers);
                bool result = ShoppingCartBLL.DeleteBook(isbn);
                Button1.Text = isbn;
                RegisterStartupScript("key", "<script type='text/javascript'>alert('成功添加到购物车');</script>");
            }
        }
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string isbn = GridView1.Rows[e.RowIndex].Cells[1].Text;
        bool result = ShoppingCartBLL.DeleteBook(isbn);
        Button1.Text = isbn.ToString();
        if (result)
        {
            RegisterStartupScript("key", "<script type='text/javascript'>alert('删除成功');</script>");
        }
        else
            RegisterStartupScript("key", "<script type='text/javascript'>alert('删除失败');</script>");
        Bind();
    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
}