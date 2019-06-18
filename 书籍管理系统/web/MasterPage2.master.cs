using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usrName"] != null)
        {
            HyperLink1.Text = (string)Session["usrName"];
            HyperLink2.Text = "  注销";
            HyperLink2.NavigateUrl = "~/Default.aspx";
            
        }
        else
            Response.Redirect("Default.aspx");

    }
    protected void SeekBtn_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("BookMin.aspx?BookName="+SeekText.Text);
    }

    protected void SeekText_TextChanged(object sender, EventArgs e)
    {

    }
}
