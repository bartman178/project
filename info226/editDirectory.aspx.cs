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
        tbCompName.Text = testOrganisation.companyName;
        tbBuildName.Text = testOrganisation.buildName;
        tbStreetName.Text = testOrganisation.streetName;
        tbTown.Text = testOrganisation.town;
        tbPostCode.Text = testOrganisation.postCode;
        tbEmail.Text = testOrganisation.email;
        tbPhone.Text = testOrganisation.phoneNumber;
        tbContactName.Text = testOrganisation.contactName;
        tbContactEmail.Text = testOrganisation.contactEmail;
        tbContactPhone.Text = testOrganisation.contactPhone;
        tbLastDate.Text = testOrganisation.lastDate;
        tbContractor.Text = testOrganisation.contractor;
        tbNotes.Text = testOrganisation.notes;
        tbMaintenance.Text = testOrganisation.maintenance;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}