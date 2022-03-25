<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APhone.aspx.cs" Inherits="Phone_APhone" %>

<!DOCTYPE html>
<!-- Written by Ethan Frizzell P2596393 -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}
        

        .auto-style1 {
            position: absolute;
            top: 343px;
            left: 1245px;
            z-index: 1;
            width: 190px;
            height: 185px;
            margin-top: 3px;
            border-radius: 16px;
            overflow: hidden;
        }

        .auto-style1 {
            position: absolute;
            top: 51px;
            left: 40px;
            z-index: 1;
            width: 291px;
            height: 192px;
        }
        .auto-style2 {
            position: absolute;
            top: 52px;
            left: 357px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 79px;
            left: 357px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 105px;
            left: 356px;
            z-index: 1;
            width: 79px;
        }
        .auto-style5 {
            position: absolute;
            top: 151px;
            left: 356px;
            z-index: 1;
            width: 84px;
        }
        .auto-style6 {
            position: absolute;
            top: 195px;
            left: 355px;
            z-index: 1;
            width: 88px;
        }
        .auto-style7 {
            position: absolute;
            left: 354px;
            z-index: 1;
            width: 88px;
            height: 38px;
            top: 241px;
        }
        .auto-style8 {
            position: absolute;
            top: 289px;
            left: 354px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 316px;
            left: 354px;
            z-index: 1;
            width: 94px;
        }
        .auto-style10 {
            position: absolute;
            top: 49px;
            left: 452px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 85px;
            left: 454px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 126px;
            left: 452px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 168px;
            left: 451px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 209px;
            left: 451px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 251px;
            left: 450px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 286px;
            left: 451px;
            z-index: 1;
            margin-top: 1px;
        }
        .auto-style17 {
            position: absolute;
            top: 316px;
            z-index: 1;
            left: 452px;
        }
        .auto-style18 {
            position: absolute;
            top: 357px;
            left: 353px;
            z-index: 1;
            width: 60px;
        }
        .auto-style19 {
            position: absolute;
            top: 357px;
            left: 426px;
            z-index: 1;
            width: 60px;
            right: 1042px;
        }
        .auto-style20 {
            position: absolute;
            top: 357px;
            left: 496px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 271px;
            left: 57px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 297px;
            left: 56px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhones" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="lstPhones_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="lblPhoneID" runat="server" CssClass="auto-style2" Text="Phone ID" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblPhoneName" runat="server" CssClass="auto-style3" Text="Phone Name" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Phone Manufacturer" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblBatteryCapacity" runat="server" CssClass="auto-style5" Text="Battery Capacity" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblCameraQuality" runat="server" CssClass="auto-style6" Text="Camera Quality" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblStorageCapacity" runat="server" CssClass="auto-style7" Text="Storage Capacity" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblDisplaySize" runat="server" CssClass="auto-style8" Text="Display Size" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblDateReleased" runat="server" CssClass="auto-style9" Text="Date Released" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtPhoneID" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtPhoneName" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtPhoneManufacturer" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtBatteryCapacity" runat="server" CssClass="auto-style13"></asp:TextBox>
        <asp:TextBox ID="txtCameraQuality" runat="server" CssClass="auto-style14"></asp:TextBox>
        <asp:TextBox ID="txtStorageCapacity" runat="server" CssClass="auto-style15"></asp:TextBox>
        <asp:TextBox ID="txtDisplaySize" runat="server" CssClass="auto-style16"></asp:TextBox>
        <asp:TextBox ID="txtDateReleased" runat="server" CssClass="auto-style17"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style18" OnClick="btnFind_Click" Text="Find" Font-Bold="True" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style19" OnClick="btnAdd_Click" Text="Add" Font-Bold="True" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style20" OnClick="btnCancel_Click" Text="Cancel" Font-Bold="True" />
        <asp:Label ID="lblInfo" runat="server" CssClass="auto-style21" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style22" Font-Names="Arial" ForeColor="White"></asp:Label>
    </form>
</body>
</html>
