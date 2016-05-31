<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewDirectory.aspx.cs" Inherits="viewDirectory" %>

<!DOCTYPE html>
<script runat="server">

</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>View directory entry</h1>
        <h2>General information</h2>
            <h4>Company Name</h4>
        <asp:Label ID="lblComp" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Building Name</h4>
        <asp:Label ID="lblBuild" CssClass="viewlabels" runat="server" Text=""></asp:Label>
        <h2>Physical Address</h2>
            <h4>Street Name</h4>
        <asp:Label ID="lblStreet" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Town/City</h4>
        <asp:Label ID="lblTown" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Post Code</h4>
        <asp:Label ID="lblPost" CssClass="viewlabels" runat="server" Text=""></asp:Label>
        <h2>Contact Information (Business)</h2>
            <h4>Business Email</h4>
        <asp:Label ID="lblEmail" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Business Phone</h4>
        <asp:Label ID="lblPhone" CssClass="viewlabels" runat="server" Text=""></asp:Label>
        <h2>Contact Information (Person Responsible)</h2>
            <h4>Name</h4>
        <asp:Label ID="lblContName" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Email</h4>
        <asp:Label ID="lblContEmail" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Work phone</h4>
        <asp:Label ID="lblContPhone" CssClass="viewlabels" runat="server" Text=""></asp:Label>
        <h2>General Building Information</h2>
            <h4>Last maintenance Date</h4>
        <asp:Label ID="lblDate" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Last contractor</h4>
        <asp:Label ID="lblContractor" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Building inspector notes</h4>
        <asp:Label ID="lblNotes" CssClass="viewlabels" runat="server" Text=""></asp:Label>
            <h4>Required maintenance work</h4>
        <asp:Label ID="lblMaintenance" CssClass="viewlabels" runat="server" Text=""></asp:Label>
        <br /><br />
        <asp:Button ID="Button1" CssClass="action-button shadow animate red" runat="server" Text="Return to Directory" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
