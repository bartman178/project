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
    Organisation testOrganisation = new Organisation("place", "build name", "street", "town", "code", "email", "number", "cont name", "cont email", "cont phone", "date", "contractor", "notes", "maintenance");
    // StoredInformation.organisationDb.Add testOrganisation ; fix later //

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
        try
        {
            string file = @"\buildings.xml";
            string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");
            string absolute_path = rel_dir = file;


            if (File.Exists(absolute_path))
            {
                File.Delete(absolute_path);
            }


            StreamWriter newFile = File.CreateText(absolute_path);

            XmlDocument doc = new XmlDocument();

            XmlNode rootNode = doc.CreateElement("buildings");

            XmlNode entityNode = doc.CreateElement("Entity");
            entityNode.InnerText = tbCompName.Text;
            XmlAttribute attribute = doc.CreateAttribute("Building Name");
            attribute.Value = tbBuildName.Text;
            entityNode.Attributes.Append(attribute);
            attribute = doc.CreateAttribute("Full Name");
            attribute.Value = tbCompName.Text;
            entityNode.Attributes.Append(attribute);
            rootNode.AppendChild(entityNode);

            doc.AppendChild(rootNode);
            doc.Save(newFile);
        }
        catch
        {
            Response.Write("<br /> *** Cannot work with file.<br />");

        }

        Response.Redirect("default.aspx");


    }
}