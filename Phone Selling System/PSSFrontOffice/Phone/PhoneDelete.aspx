<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneDelete.aspx.cs" Inherits="Phone_PhoneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 30px;
            left: 48px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 59px;
            left: 89px;
            z-index: 1;
            width: 70px;
        }
        .auto-style3 {
            position: absolute;
            top: 59px;
            left: 163px;
            z-index: 1;
            width: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblQuestion" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="No" />
    </form>
</body>
</html>
