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
using System.IO;



public partial class web_Main : System.Web.UI.Page
{
    private List<string> lstSort = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();

          
        }
        
  lstSort.Add("a类");
            lstSort.Add("b类");
            lstSort.Add("c类");
            lstSort.Add("d类");
            lstSort.Add("e类");
    }

    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        //GridView1.PageIndex = e.NewPageIndex;
        //Bind();
    }
    private void Bind()
    { 
        List<BookInfo> lstBooks = BookInfoBLL.FinfAllBooks();
        GridView1.DataSource = lstBooks;
        GridView1.DataBind();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string isbn = GridView1.Rows[e.RowIndex].Cells[0].Text;
        bool result=BookInfoBLL.DeleteBook(isbn);
        if (result)
        {
           RegisterStartupScript("key", "<script type='text/javascript'>alert('删除成功');</script>");
        }
        else
            RegisterStartupScript("key", "<script type='text/javascript'>alert('删除失败');</script>");
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox txtisbn = GridView1.Rows[e.RowIndex].Cells[0].Controls[0] as TextBox;
        TextBox txtBookName= GridView1.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox;
       TextBox txtbookAuthor = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;
       TextBox txtPrice = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;
       TextBox txtCountIn = GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox;
       TextBox txtCountOut = GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox;
       TextBox txtBookAbout = GridView1.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox;
       TextBox txtBookType = GridView1.Rows[e.RowIndex].Cells[7].Controls[1] as TextBox; 
        

       BookInfo book = new BookInfo();
       book.BookName = txtBookName.Text;
       book.BookAuthor = txtbookAuthor.Text;
       book.isbn = Convert.ToInt32(txtisbn.Text);
       book.Price = float.Parse(txtPrice.Text);
       book.CountIn = Convert.ToInt32(txtCountIn.Text);
       book.CountOut = Convert.ToInt32(txtCountOut.Text);
       book.BookAbout = txtBookAbout.Text;
       book.BookType = txtBookType.Text;
       //book.image = 
       bool result=BookInfoBLL.UpdateBook(book);
       if (result)
       {
           RegisterStartupScript("key", "<script type='text/javascript'>alert('更新成功');</script>");
       }
       else
           RegisterStartupScript("key", "<script type='text/javascript'>alert('更新失败');</script>");


       GridView1.EditIndex = -1;
       Bind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    } 
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
        //mei xie
    }
    protected void GridView1_RowUpdating(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowState == DataControlRowState.Edit)
        { 
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddlSort = (DropDownList)e.Row.Cells[7].FindControl("ddlSort");
                ddlSort.DataSource = lstSort; 
                ddlSort.DataBind();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }


    protected void button_Click(object sender, EventArgs e)
    {

    }
}