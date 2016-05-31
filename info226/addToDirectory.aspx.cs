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
        if (string.IsNullOrEmpty(tbCompName.Text) || string.IsNullOrEmpty(tbBuildName.Text) || string.IsNullOrEmpty(tbStreetName.Text) || string.IsNullOrEmpty(tbTown.Text) || string.IsNullOrEmpty(tbPostCode.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbContactName.Text) || string.IsNullOrEmpty(tbContactEmail.Text) || string.IsNullOrEmpty(tbContactPhone.Text) || string.IsNullOrEmpty(tbLastDate.Text) || string.IsNullOrEmpty(tbContractor.Text) || string.IsNullOrEmpty(tbNotes.Text) || string.IsNullOrEmpty(tbMaintenance.Text))
        {
            lblError.Text = ("Please fill in blank fields");
        }
        else
        {
            Database.data.Add(new Organisation(tbCompName.Text, tbBuildName.Text, tbStreetName.Text, tbTown.Text, int.Parse(tbPostCode.Text), tbEmail.Text, int.Parse(tbPhone.Text), tbContactName.Text, tbContactEmail.Text, int.Parse(tbContactPhone.Text), tbLastDate.Text, tbContractor.Text, tbNotes.Text, tbMaintenance.Text));
            Response.Redirect("directory.aspx");
        }
    }
}