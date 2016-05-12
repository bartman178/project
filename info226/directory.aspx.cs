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
        XmlDocument doc = new XmlDocument();
        try
        {
            string file = @"\directory.xml";
            string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");
            string absolute_path = rel_dir + file;

            if (File.Exists(absolute_path))
            {
                doc.Load(absolute_path);
            }
            else
            {
                Response.Write("<br /> *** Oh no! <br />");
                Response.Write("*** File " + absolute_path + "does not exist. <br />");
            }

            XmlNodeList allItems = doc.GetElementsByTagName("OrganisationName");

            for (int i = 0; i < allItems.Count; i++)
            {
                ListBox1.Items.Add(allItems[i].InnerText);
            }
        }
        catch
        {
            ListBox1.Items.Add("Empty!");
        }

    }
    protected void Edit_Click(object sender, EventArgs e)
    {
        Response.Redirect("editDirectory.aspx");

    }
    protected void Home_Click(object sender, EventArgs e)
    {
        Server.Transfer("default.aspx");
    }
    protected void Search_Click(object sender, EventArgs e)
    {
       
    }
}