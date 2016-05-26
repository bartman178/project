<%@ Page Language="C#" AutoEventWireup="true" CodeFile="help.aspx.cs" Inherits="help" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" CssClass="action-button shadow animate red" runat="server" Text="Back to home" OnClick="Button1_Click" />
        <h1>Help/Contact Information</h1>
        <h2>Website Help</h2>
        <p>Contact support on 1345678</p>
        <p>Email support@happybuildings.com</p>
        <h2>Other Help</h2>
        <p>Contact person assigned to building</p>
        <p>OR</p>
        <p>contact Happy Buildings manager on 9876543</p>
        <p>Email manager@happybuildings.com</p>
    </div>
    </form>
</body>
</html>
