using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using DAL;
using BLL;

public partial class Default2 : System.Web.UI.Page
{
    
    private UsrInfo user;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        user = new UsrInfo();
        user.UsrName = txtUsername.Text;
        user.UsrPwd = txtPwd.Text;
        user.UsrEmail = txtEmail.Text;

        bool result = UsrInfoBLL.login(txtUsername.Text, txtPwd.Text);
        if (result)
        {
            Response.Write("<script type='text/javascript'>alert('错误，已存在同样名称');</script>");
        }
        else
        {
            result = UsrInfoBLL.AddUser(user);
            if (result)
            {
                Response.Write("<script type='text/javascript'>alert('注册成功');</script>");
                Server.Transfer("Default.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('注册失败');</script>");
        }


        }
    }
}