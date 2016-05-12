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

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        List<string> newList = new List<string>();
        TextBox[] textBoxes = { tbCompName, tbBuildName, tbStreetName, tbTown, tbPostCode, tbEmail, tbPhone, tbContactName, tbContactEmail, tbContactPhone, tbLastDate, tbContractor, tbNotes, tbMaintenance};

        for (int i = 0; i < textBoxes.Length; i++)
        {
            newList.Add(Convert.ToString(textBoxes[i].Text));
        }

        Response.Redirect("default.aspx");
    }
}