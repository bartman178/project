using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("help.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("addToDirectory.aspx");
    }
    protected void logOut_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Response.Redirect("login.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("directory.aspx");
    }
}