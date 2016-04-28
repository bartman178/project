<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="-1" />
</head>
<body>
    <form id="form1" runat="server">

        <fieldset>
            <legend>Please Login:</legend>
            <label for="txtUserName">Email:</label>
            <input id="txtUserName" name="txtUserName" type="text" runat="server" />
            <br />
            <label for="txtUserPass">Password:</label>

            <input id="txtUserPass" name="txtUserPass" type="password" runat="server" />
            <br />
            <label for="txtUserName">Stay Logged In:</label>

            <asp:CheckBox ID="chkPersistCookie" runat="server" AutoPostBack="false" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><p></p>
            <asp:Label ID="lblMsg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server" />
        </fieldset>
    </form>
</body>
</html>
