using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            foreach (Organisation org in Database.data)
            {
                if (org.name.Equals(Session["Org"]))
                {
                    tbCompName.Text = org.name;
                    tbBuildName.Text = org.buildname;
                    tbStreetName.Text = org.street;
                    tbTown.Text = org.town;
                    tbPostCode.Text = org.postcode.ToString();
                    tbEmail.Text = org.email;
                    tbPhone.Text = org.phone.ToString();
                    tbContactName.Text = org.contactname;
                    tbContactEmail.Text = org.contactemail;
                    tbContactPhone.Text = org.contactphone.ToString();
                    tbLastDate.Text = org.lastmaintenance;
                    tbContractor.Text = org.lastcontractor;
                    tbNotes.Text = org.notes;
                    tbMaintenance.Text = org.maintenancework;
                }
            }
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tbCompName.Text) || string.IsNullOrEmpty(tbBuildName.Text) || string.IsNullOrEmpty(tbStreetName.Text) || string.IsNullOrEmpty(tbTown.Text) || string.IsNullOrEmpty(tbPostCode.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbContactName.Text) || string.IsNullOrEmpty(tbContactEmail.Text) || string.IsNullOrEmpty(tbContactPhone.Text) || string.IsNullOrEmpty(tbLastDate.Text) || string.IsNullOrEmpty(tbContractor.Text) || string.IsNullOrEmpty(tbNotes.Text) || string.IsNullOrEmpty(tbMaintenance.Text))
        {
            lblError.Text = ("Please fill in blank fields");
        }
        else
        {
            foreach (Organisation org in Database.data)
            {
                if (org.name.Equals(Session["Org"]))
                {
                    org.name = tbCompName.Text;
                    org.buildname = tbBuildName.Text;
                    org.street = tbStreetName.Text;
                    org.town = tbTown.Text;
                    org.postcode = int.Parse(tbPostCode.Text);
                    org.email = tbEmail.Text;
                    org.phone = int.Parse(tbPhone.Text);
                    org.contactname = tbContactName.Text;
                    org.contactemail = tbContactEmail.Text;
                    org.contactphone = int.Parse(tbContactPhone.Text);
                    org.lastmaintenance = tbLastDate.Text;
                    org.lastcontractor = tbContractor.Text;
                    org.notes = tbNotes.Text;
                    org.maintenancework = tbMaintenance.Text;
                }
            }
            Response.Redirect("directory.aspx");
        }
    }
}