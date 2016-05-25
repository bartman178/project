using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class viewDirectory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (Organisation org in Database.data)
            {
                if (org.name.Equals(Session["Org"]))
                {
                    lblComp.Text = org.name;
                    lblBuild.Text = org.buildname;
                    lblStreet.Text = org.street;
                    lblTown.Text = org.town;
                    lblPost.Text = org.postcode.ToString();
                    lblEmail.Text = org.email;
                    lblPhone.Text = org.phone.ToString();
                    lblContName.Text = org.contactname;
                    lblContEmail.Text = org.contactemail;
                    lblContPhone.Text = org.contactphone.ToString();
                    lblDate.Text = org.lastmaintenance;
                    lblContractor.Text = org.lastcontractor;
                    lblNotes.Text = org.notes;
                    lblMaintenance.Text = org.maintenancework;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("directory.aspx");
    }
}