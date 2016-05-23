using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Organisation
/// </summary>
public class Organisation
{
    public string name;
    public string buildname;
    public string street; 
    public string town;
    public int postcode; 
    public string email;
    public int phone;
    public string contactname;
    public string contactemail;
    public int contactphone;
    public string lastmaintenance;
    public string lastcontractor;
    public string notes;
    public string maintenancework;

    public Organisation(string name, string buildname, string street, string town, int postcode, string email, int phone, string contactname, string contactemail, int contactphone, string lastmaintenance, string lastcontractor, string notes, string maintenancework)
	{
        this.name = name;
        this.buildname = buildname;
        this.street = street;
        this.town = town;
        this.postcode = postcode;
        this.email = email;
        this.phone = phone;
        this.contactname = contactname;
        this.contactemail = contactemail;
        this.contactphone = contactphone;
        this.lastmaintenance = lastmaintenance;
        this.lastcontractor = lastcontractor;
        this.notes = notes;
        this.maintenancework = maintenancework;
	}
}