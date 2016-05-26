using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows;

public partial class directory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    
    {
        if (!IsPostBack)
            {

            if (!Database.isLoaded)
            {

                XmlDocument doc = new XmlDocument();
                try
                {
                    string file = @"\db.xml";
                    string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");
                    string absolute_path = rel_dir + file;

                    if (File.Exists(absolute_path))
                    {
                        doc.Load(absolute_path);
                    }
                    else
                    {
                        Response.Write("NO FILE");
                    }

                    XmlNodeList names = doc.GetElementsByTagName("name");
                    XmlNodeList buildingnames = doc.GetElementsByTagName("buildname");
                    XmlNodeList streets = doc.GetElementsByTagName("street");
                    XmlNodeList towns = doc.GetElementsByTagName("town");
                    XmlNodeList postcodes = doc.GetElementsByTagName("postcode");
                    XmlNodeList emails = doc.GetElementsByTagName("email");
                    XmlNodeList phones = doc.GetElementsByTagName("phone");
                    XmlNodeList contactnames = doc.GetElementsByTagName("contactname");
                    XmlNodeList contactemails = doc.GetElementsByTagName("contactemail");
                    XmlNodeList contactphones = doc.GetElementsByTagName("contactphone");
                    XmlNodeList lastmaninenances = doc.GetElementsByTagName("lastmaintenance");
                    XmlNodeList lastcontractors = doc.GetElementsByTagName("lastcontractor");
                    XmlNodeList notes = doc.GetElementsByTagName("notes");
                    XmlNodeList maintenanceworks = doc.GetElementsByTagName("maintenancework");

                    for (int i = 0; i < names.Count; i++)
                    {
                        Organisation org = new Organisation(names[i].InnerText, buildingnames[i].InnerText, streets[i].InnerText, towns[i].InnerText, int.Parse(postcodes[i].InnerText), emails[i].InnerText, int.Parse(phones[i].InnerText), contactnames[i].InnerText, contactemails[i].InnerText, int.Parse(contactphones[i].InnerText), lastmaninenances[i].InnerText, lastcontractors[i].InnerText, notes[i].InnerText, maintenanceworks[i].InnerText);
                        Database.data.Add(org);
                    }

                    Database.isLoaded = true;

                }
                catch
                {
                    Response.Write("ERROR");
                }
            }
            foreach (Organisation org in Database.data)
            {
                ListBox1.Items.Add(org.name);
            }
            }
       }
    protected void Edit_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedItem != null)
        {
            Session["Org"] = ListBox1.SelectedItem.ToString();
            Response.Redirect("editDirectory.aspx");
        }

    }
    protected void Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void Search_Click(object sender, EventArgs e)
    {
       
    }
    protected void View_Click(object sender, EventArgs e)
    {
        Session["Org"] = ListBox1.SelectedItem.ToString();
        Response.Redirect("viewDirectory.aspx");
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("addToDirectory.aspx");
    }
    protected void Save_Click(object sender, EventArgs e)
    {
        try
        {
            string file = @"\db.xml";
            string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");
            string absolute_path = rel_dir + file;

            if (File.Exists(absolute_path))
            {
                File.Delete(absolute_path);
            }
            StreamWriter newFile = File.CreateText(absolute_path);

            XmlDocument doc = new XmlDocument();
            XmlNode rootNode = doc.CreateElement("data");

            foreach (Organisation org in Database.data)
            {
                XmlNode orgNode = doc.CreateElement("organisation");

                XmlNode nameNode = doc.CreateElement("name");
                nameNode.InnerText = org.name;

                XmlNode buildNode = doc.CreateElement("buildname");
                buildNode.InnerText = org.buildname;

                XmlNode streetNode = doc.CreateElement("street");
                streetNode.InnerText = org.street;

                XmlNode townNode = doc.CreateElement("town");
                townNode.InnerText = org.town;

                XmlNode postcodeNode = doc.CreateElement("postcode");
                postcodeNode.InnerText = org.postcode.ToString();

                XmlNode emailNode = doc.CreateElement("email");
                emailNode.InnerText = org.email;

                XmlNode phoneNode = doc.CreateElement("phone");
                phoneNode.InnerText = org.phone.ToString();

                XmlNode contnameNode = doc.CreateElement("contactname");
                contnameNode.InnerText = org.contactname;

                XmlNode contemailNode = doc.CreateElement("contactemail");
                contemailNode.InnerText = org.contactemail;

                XmlNode contphoneNode = doc.CreateElement("contactphone");
                contphoneNode.InnerText = org.contactphone.ToString();

                XmlNode lastmaintenanceNode = doc.CreateElement("lastmaintenance");
                lastmaintenanceNode.InnerText = org.lastmaintenance;

                XmlNode contractorNode = doc.CreateElement("lastcontractor");
                contractorNode.InnerText = org.lastcontractor;

                XmlNode notesNode = doc.CreateElement("notes");
                notesNode.InnerText = org.notes;

                XmlNode maintenanceNode = doc.CreateElement("maintenancework");
                maintenanceNode.InnerText = org.maintenancework;

                orgNode.AppendChild(nameNode);
                orgNode.AppendChild(buildNode);
                orgNode.AppendChild(streetNode);
                orgNode.AppendChild(townNode);
                orgNode.AppendChild(postcodeNode);
                orgNode.AppendChild(emailNode);
                orgNode.AppendChild(phoneNode);
                orgNode.AppendChild(contnameNode);
                orgNode.AppendChild(contemailNode);
                orgNode.AppendChild(contphoneNode);
                orgNode.AppendChild(lastmaintenanceNode);
                orgNode.AppendChild(contractorNode);
                orgNode.AppendChild(notesNode);
                orgNode.AppendChild(maintenanceNode);

                rootNode.AppendChild(orgNode);
            }

            doc.AppendChild(rootNode);
            doc.Save(newFile);

            newFile.Close();
        }
        catch
        {
            Response.Write("ERROR");
        }
    }
    protected void Delete_Click(object sender, EventArgs e)
    {
        Organisation toRemove = null;
        foreach (Organisation org in Database.data)
        {
            if (org.name.Equals(ListBox1.SelectedItem.ToString()))
            {
                toRemove = org;
            }
        }
        if (toRemove != null)
        {
            Database.data.Remove(toRemove);
        }

        ListBox1.Items.Clear();
        foreach (Organisation org in Database.data)
        {
            ListBox1.Items.Add(org.name);
        }
    }
}