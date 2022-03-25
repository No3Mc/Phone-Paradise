<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainStaff.aspx.cs" Inherits="Staff_MainStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtDisplay" runat="server" Height="179px" Width="219px"></asp:TextBox>
        <asp:Button ID="btnDisplay" runat="server" OnClick="Button1_Click" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnBack" runat="server" Text="Go Back" />
        <asp:Button ID="btnDel" runat="server" OnClick="btnDel_Click" Text="Delete" />
    </form>
</body>
</html>
