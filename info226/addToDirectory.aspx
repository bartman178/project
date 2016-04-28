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

            <asp:Label ID="Label1" runat="server" Text="Organisation"></asp:Label>
            <asp:Label ID="directoryName" runat="server" Text="(empty)"></asp:Label>

            <h4>Company Name</h4><asp:TextBox ID="tbCompName" runat="server"></asp:TextBox>
            <h4>Building Name</h4><asp:TextBox ID="tbBuildName" runat="server"></asp:TextBox>
        <h2>Physical Address</h2>
            <h4>Street Name</h4><asp:TextBox ID="tbStreetName" runat="server"></asp:TextBox>
            <h4>Town/City</h4><asp:TextBox ID="tbTown" runat="server"></asp:TextBox>
            <h4>Post Code</h4><asp:TextBox ID="tbPostCode" runat="server"></asp:TextBox>
        <h2>Postal Address</h2>
            <h4>Street Name/PO Box</h4><asp:TextBox ID="tbPoBox" runat="server"></asp:TextBox>
            <h4>Town/City</h4><asp:TextBox ID="tbPostalTown" runat="server"></asp:TextBox>
            <h4>Post Code</h4><asp:TextBox ID="tbPostalCode" runat="server"></asp:TextBox>    
        <h2>Contact Information (Business)</h2>
            <h4>Business Email</h4><asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <h4>Business Phone</h4><asp:TextBox ID="tbBusPhone" runat="server"></asp:TextBox>
            <h4>Freephone</h4><asp:TextBox ID="tbFreePhone" runat="server"></asp:TextBox>
            <h4>Fax Number</h4><asp:TextBox ID="tbFax" runat="server"></asp:TextBox>
        <h2>Contact Information (Person Responsible)</h2>
            <h4>Name</h4><asp:TextBox ID="tbContactName" runat="server"></asp:TextBox>
            <h4>Email</h4><asp:TextBox ID="tbContactEmail" runat="server"></asp:TextBox>
            <h4>Work phone</h4><asp:TextBox ID="tbWorkPhone" runat="server"></asp:TextBox>
        <h2>General Building Information</h2>
            <h4>Last maintenance Date</h4><asp:Calendar ID="calLastDate" runat="server"></asp:Calendar>
            <h4>Last contractor</h4><asp:TextBox ID="tbContractor" runat="server"></asp:TextBox>
            <h4>Building inspector notes</h4><asp:TextBox ID="tbNotes" runat="server"></asp:TextBox>
            <h4>Contact Person Comments</h4><asp:TextBox ID="tbComments" runat="server"></asp:TextBox>
            <h4>Required maintenance work</h4><asp:TextBox ID="tbMaintenance" runat="server"></asp:TextBox>
            <h4>Width of building</h4><asp:TextBox ID="tbWidth" runat="server"></asp:TextBox>
            <h4>Number of stories</h4>
        <asp:DropDownList ID="listStories" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
        </asp:DropDownList>
        <h2>Building image upload</h2>
            <asp:FileUpload ID="imgBuild" runat="server" />
        <h2>Building map upload</h2>
            <asp:FileUpload ID="imgMap" runat="server" />
        <br /><br /><asp:Button ID="Button1" runat="server" Text="Submit form" />
    </div>
    </form>
</body>
</html>
