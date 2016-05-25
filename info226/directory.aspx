﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="directory.aspx.cs" Inherits="directory" %>
<%@ Import Namespace="System.Xml" %>
<%@ Import Namespace="System.IO"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>

</head>
<body>
    <h1>Directory</h1>
    
    <form id="form1" runat="server">
    <div>
        <h3>Search the Directory</h3> <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox><asp:Button ID="Search" runat="server" Text="Go" OnClick="Search_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="184px" Width="519px">


        </asp:ListBox>
    
    </div>
        <asp:Button ID="Home" runat="server" Text="Back To Home" OnClick="Home_Click" />
        <asp:Button ID="View" runat="server" OnClick="View_Click" Text="View" />
        <asp:Button ID="Edit" runat="server" Text="Edit" OnClick="Edit_Click" style="height: 26px" />
    </form>
</body>
</html>
