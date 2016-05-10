using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Organisation
/// </summary>
public class Organisation
{
    public string companyName;
    public string buildName;
    public string streetName; 
    public string town;
    public string postCode; 
    public string email;
    public string phoneNumber;
    public string contactName;
    public string contactEmail;
    public string contactPhone;
    public string lastDate;
    public string contractor;
    public string notes;
    public string maintenance;

	public Organisation(string companyName, string buildName, string streetName, string town, string postCode, string email, string phoneNumber, string contactName, string contactEmail, string contactPhone, string lastDate, string contractor, string notes, string maintenance)
	{
        this.companyName = companyName;
        this.buildName = buildName;
        this.streetName = streetName;
        this.town = town;
        this.postCode = postCode;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.contactName = contactName;
        this.contactEmail = contactEmail;
        this.contactPhone = contactPhone;
        this.lastDate = lastDate;
        this.contractor = contractor;
        this.notes = notes;
        this.maintenance = maintenance;
	}
}