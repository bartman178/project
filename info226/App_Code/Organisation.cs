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
    public string streetName; 
    public string town;
    public string postCode; 
    public string email;
    public string phoneNumber;

	public Organisation(string companyName, string streetName, string town, string postCode, string email, string phoneNumber)
	{
        this.companyName = companyName;
        this.streetName = streetName;
        this.town = town;
        this.postCode = postCode;
        this.email = email;
        this.phoneNumber = phoneNumber;
	}
}