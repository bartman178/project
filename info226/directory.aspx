<%@ Page Language="C#" AutoEventWireup="true" CodeFile="directory.aspx.cs" Inherits="directory" %>
<%@ Import Namespace="System.Xml" %>
<%@ Import Namespace="System.IO"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button2" runat="server" Text="back to home" OnClick="Button2_Click" />
        <asp:ListBox ID="ListBox1" runat="server">


        </asp:ListBox>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" style="height: 26px" />
    </form>
</body>
</html>
