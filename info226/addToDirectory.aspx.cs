using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Organisation testOrganisation = new Organisation("place", "street", "town", "code", "email", "number");
   // StoredInformation.organisationDb.Add testOrganisation ; fix later //

    protected void Page_Load(object sender, EventArgs e)
    {
        tbCompName.Text = testOrganisation.companyName;
        tbStreetName.Text = testOrganisation.streetName;
        tbTown.Text = testOrganisation.town;
        tbPostCode.Text = testOrganisation.postCode;
        tbEmail.Text = testOrganisation.email;
        tbWorkPhone.Text = testOrganisation.phoneNumber;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("default.aspx");
    }
}