using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private string connectionString;
    private string cmdText;
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        bool result=UsrInfoBLL.login(username.Text, password.Text);
        if (result)
        {
            Session["usrName"] = username.Text;
            Session.Timeout = 2;
            Response.Redirect("./home_page.aspx");
            Response.Write("<script type='text/javascript'>alert('登录成功');</script>");
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('登录失败');</script>");
        }
    }
    protected void registerBtn_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}