<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneDelete.aspx.cs" Inherits="Phone_PhoneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 38px;
            left: 74px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 87px;
            left: 115px;
            z-index: 1;
            right: 1327px;
        }
        .auto-style3 {
            position: absolute;
            top: 87px;
            left: 172px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>
