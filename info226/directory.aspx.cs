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

                    foreach (Organisation org in Database.data)
                    {
                        ListBox1.Items.Add(org.name);
                    }
                }
                catch
                {
                    Response.Write("ERROR");
                }
            }

       }
    protected void Edit_Click(object sender, EventArgs e)
    {
        Session["Org"] = ListBox1.SelectedItem.ToString();
        Response.Redirect("editDirectory.aspx");

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
}