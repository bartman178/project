<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addToDirectory.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button2" runat="server" Text="Back to home" OnClick="Button2_Click" />
        <h1>Add to directory</h1>
        <h2>General information</h2>
            <h4>Company Name</h4><asp:TextBox ID="tbCompName" runat="server"></asp:TextBox>
            <h4>Building Name</h4><asp:TextBox ID="tbBuildName" runat="server"></asp:TextBox>
        <h2>Physical Address</h2>
            <h4>Street Name</h4><asp:TextBox ID="tbStreetName" runat="server"></asp:TextBox>
            <h4>Town/City</h4><asp:TextBox ID="tbTown" runat="server"></asp:TextBox>
            <h4>Post Code</h4><asp:TextBox ID="tbPostCode" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>Contact Information (Business)</h2>
            <h4>Business Email</h4><asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <h4>Business Phone</h4><asp:TextBox ID="tbPhone" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>Contact Information (Person Responsible)</h2>
            <h4>Name</h4><asp:TextBox ID="tbContactName" runat="server"></asp:TextBox>
            <h4>Email</h4><asp:TextBox ID="tbContactEmail" runat="server"></asp:TextBox>
            <h4>Work phone</h4><asp:TextBox ID="tbContactPhone" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>General Building Information</h2>
            <h4>Last maintenance Date</h4><asp:TextBox ID="tbLastDate" runat="server"></asp:TextBox>
            <h4>Last contractor</h4><asp:TextBox ID="tbContractor" runat="server"></asp:TextBox>
            <h4>Building inspector notes</h4><asp:TextBox ID="tbNotes" runat="server" Height="74px" Width="446px"></asp:TextBox>
            <h4>Required maintenance work</h4><asp:TextBox ID="tbMaintenance" runat="server" Height="74px" Width="446px"></asp:TextBox>
        <br /><br /><asp:Button ID="submit" runat="server" Text="Submit form" OnClick="Submit_Click" />
    </div>
    </form>
</body>
</html>
