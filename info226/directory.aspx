<%@ Page Language="C#" AutoEventWireup="true" CodeFile="directory.aspx.cs" Inherits="directory" %>
<%@ Import Namespace="System.Xml" %>
<%@ Import Namespace="System.IO"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>

</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Button ID="Home" runat="server" Text="Back To Home" OnClick="Home_Click" />
    <h1>Directory</h1>
    
    <div>
        <h3>Search the Directory</h3> <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox><asp:Button ID="Search" runat="server" Text="Go" OnClick="Search_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="184px" Width="519px">


        </asp:ListBox>
    
    </div>
        <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
        <asp:Button ID="View" runat="server" OnClick="View_Click" Text="View" />
        <asp:Button ID="Edit" runat="server" Text="Edit" OnClick="Edit_Click" style="height: 26px" />
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />

        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" />

    </form>
</body>
</html>
