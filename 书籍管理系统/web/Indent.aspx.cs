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

public partial class Indent_aspx : System.Web.UI.Page
{
    public double cost = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { 
            Bind();
            cost = CalculateSum();
            Label1.Text ="合计总价：" +  cost.ToString();
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string isbn = GridView1.Rows[e.RowIndex].Cells[0].Text;
        bool result = BookInfoBLL.DeleteIndent(isbn);
        if (result)
        {
            RegisterStartupScript("key", "<script type='text/javascript'>alert('删除成功');</script>");
        }
        else
            RegisterStartupScript("key", "<script type='text/javascript'>alert('删除失败');</script>");
        Bind();
        cost = CalculateSum();
        Label1.Text = "合计总价：" + cost.ToString();
    }
    private void Bind()
    {
        List<BookInfo> lstBooks = BookInfoBLL.FinfAllBooksIndent(true); //显示购物车
        GridView1.DataSource = lstBooks;
        GridView1.DataBind();
    }
    public double CalculateSum()
    {
        double sum = 0;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            sum += Convert.ToDouble(GridView1.Rows[i].Cells[6].Text) * Convert.ToDouble(GridView1.Rows[i].Cells[3].Text);
        }
        return sum;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}