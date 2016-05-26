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
        Server.Transfer("help.aspx");
    }
    protected void logOut_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
        Server.Transfer("login.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("directory.aspx");
    }
}