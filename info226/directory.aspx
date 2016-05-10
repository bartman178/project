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
    <h1>Directory</h1>
    
    <form id="form1" runat="server">
    <div>
        <h3>Search the Directory</h3> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button3" runat="server" Text="Go" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server">


        </asp:ListBox>
    
    </div>
        <asp:Button ID="Button2" runat="server" Text="Back To Home" OnClick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" style="height: 26px" />
    </form>
</body>
</html>
