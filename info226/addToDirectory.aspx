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
        <asp:Button ID="Button2" CssClass="action-button shadow animate red" runat="server" Text="Back to directory" OnClick="Button2_Click" />
        <h1>Add to directory</h1>
        <h2>General information</h2>
        <asp:Label ID="lblError" CssClass="error" runat="server" Text=""></asp:Label>
            <h4>Company Name</h4><asp:TextBox ID="tbCompName" CssClass="box" runat="server"></asp:TextBox>
            <h4>Building Name</h4><asp:TextBox ID="tbBuildName" CssClass="box" runat="server"></asp:TextBox>
        <h2>Physical Address</h2>
            <h4>Street Name</h4><asp:TextBox ID="tbStreetName" CssClass="box" runat="server"></asp:TextBox>
            <h4>Town/City</h4><asp:TextBox ID="tbTown" CssClass="box" runat="server"></asp:TextBox>
            <h4>Post Code</h4><asp:TextBox ID="tbPostCode" CssClass="box" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>Contact Information (Business)</h2>
            <h4>Business Email</h4><asp:TextBox ID="tbEmail" CssClass="box" runat="server"></asp:TextBox>
            <h4>Business Phone</h4><asp:TextBox ID="tbPhone" CssClass="box" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>Contact Information (Person Responsible)</h2>
            <h4>Name</h4><asp:TextBox ID="tbContactName" CssClass="box" runat="server"></asp:TextBox>
            <h4>Email</h4><asp:TextBox ID="tbContactEmail" CssClass="box" runat="server"></asp:TextBox>
            <h4>Work phone</h4><asp:TextBox ID="tbContactPhone" CssClass="box" runat="server" onkeydown = "return (!((event.keyCode>=65 && event.keyCode <= 95) || event.keyCode >= 106) && event.keyCode!=32);"></asp:TextBox>
        <h2>General Building Information</h2>
            <h4>Last maintenance Date</h4><asp:TextBox ID="tbLastDate" CssClass="box" runat="server"></asp:TextBox>
            <h4>Last contractor</h4><asp:TextBox ID="tbContractor" CssClass="box" runat="server"></asp:TextBox>
            <h4>Building inspector notes</h4><asp:TextBox ID="tbNotes" CssClass="box" runat="server" Height="74px" Width="446px"></asp:TextBox>
            <h4>Required maintenance work</h4><asp:TextBox ID="tbMaintenance" CssClass="box" runat="server" Height="74px" Width="446px"></asp:TextBox>
        <br /><br />
        <h4>Please make sure all fields are filled in before submitting.</h4>
        <asp:Button ID="submit" CssClass="action-button shadow animate red" runat="server" Text="Submit form" OnClick="Submit_Click" />
    </div>
    </form>
</body>
</html>
