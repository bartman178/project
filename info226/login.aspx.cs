using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Abandon();
    }

    private bool ValidateUser(string userName, string passWord)
    {
        bool validPass = false;

        if ((userName == WebConfigurationManager.AppSettings["adminUsername"].ToString()) && (passWord == WebConfigurationManager.AppSettings["adminPassword"].ToString()))
        {
            validPass = true;
        }

        return validPass;

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (ValidateUser(txtUserName.Value, txtUserPass.Value))
            FormsAuthentication.RedirectFromLoginPage(txtUserName.Value,
                chkPersistCookie.Checked);
        else
            userMsg("Incorrect user and / or password incorrect. Please try again.");
    }

    protected void userMsg(string msg)
    {
        lblMsg.Text = msg;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("loginHelp.aspx");
    }
}