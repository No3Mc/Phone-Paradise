<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneDelete.aspx.cs" Inherits="Phone_PhoneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}

            .auto-style2 {
            position: absolute;
            top: 87px;
            left: 133px;
            z-index: 1;
            width: 70px;
        }
        .auto-style3 {
            position: absolute;
            top: 87px;
            left: 203px;
            z-index: 1;
            width: 70px;
        }

        
           
        .auto-style4 {
            position: absolute;
            top: 47px;
            left: 52px;
            z-index: 1;
            width: 453px;
            height: 185px;
            border-radius: 16px;
            overflow: hidden;
            margin-top: 3px;
        }

        
           
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Are you sure you want to delete this record?" Font-Bold="True" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="Yes" Font-Bold="True" Font-Names="Arial" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="No" Font-Bold="True" Font-Names="Arial" />
    </form>
</body>
</html>
