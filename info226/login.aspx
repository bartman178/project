<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="-1" />
    <style>
        body{
           font-family: sans-serif, Arial, Helvetica, Verdana;
           background-color: #347BFF;
           text-align: center;
        }

        fieldset{
             padding: 1em;
             text-align: center;
        }

        legend{
            color: #ffffff;
            font-family: 'Raleway',sans-serif;
            font-size: 62px;
            font-weight: 800;
            line-height: 72px;
            margin: 0 0 24px;
            text-align: center;
            text-transform: uppercase;
            text-shadow: 0 1px 0 #ccc, 0 2px 0 #c9c9c9, 0 3px 0 #bbb, 0 4px 0 #b9b9b9, 0 5px 0 #aaa, 0 6px 1px rgba(0,0,0,.1), 0 0 5px rgba(0,0,0,.1), 0 1px 3px rgba(0,0,0,.3), 0 3px 5px rgba(0,0,0,.2), 0 5px 10px rgba(0,0,0,.25), 0 10px 10px rgba(0,0,0,.2), 0 20px 20px rgba(0,0,0,.15);
        }


        label{
            color: #ffffff;
            font-family: 'Raleway',sans-serif;
            font-size: 24px;
            font-weight: 800;
            line-height: 36px;
            margin: 0 0 24px;
            text-align: center;
        }

        input{
            margin-bottom: .5em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <fieldset>
            <legend>Please Login to Access Happy Buildings</legend>
            <label for="txtUserName">Username:</label>&nbsp;
            <input id="txtUserName" name="txtUserName" type="text" runat="server" /><br />
            <label for="txtUserPass">Password:</label>

            <input id="txtUserPass" name="txtUserPass" type="password" runat="server" />
            <br />
            <label for="txtUserName">Stay Logged In:</label>

            <asp:CheckBox ID="chkPersistCookie" runat="server" AutoPostBack="false" />
            <br /><br />
            <asp:Button ID="btnLogin" CssClass="action-button shadow animate red" runat="server" Text="Login" OnClick="btnLogin_Click" /><p>
                <asp:Button ID="Button2" CssClass="action-button shadow animate red" runat="server" Text="Login Help" OnClick="Button2_Click" /></p>
            
            <asp:Label ID="lblMsg" ForeColor="darkred" Font-Name="Verdana" Font-Bold="true" Font-Size="20" runat="server" />
        </fieldset>
        
    </form>
 
</body>

</html>
