<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APhone.aspx.cs" Inherits="Phone_PhoneAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 16px;
            left: 127px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 18px;
            left: 35px;
            z-index: 1;
            right: 417px;
        }
        .auto-style3 {
            position: absolute;
            top: 46px;
            left: 35px;
            z-index: 1;
            width: 80px;
        }
        .auto-style4 {
            position: absolute;
            top: 46px;
            left: 127px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 72px;
            left: 36px;
            z-index: 1;
            width: 87px;
        }
        .auto-style6 {
            position: absolute;
            top: 81px;
            left: 125px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 119px;
            left: 34px;
            z-index: 1;
            width: 88px;
        }
        .auto-style8 {
            position: absolute;
            top: 129px;
            left: 124px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 169px;
            left: 36px;
            z-index: 1;
            width: 81px;
        }
        .auto-style10 {
            position: absolute;
            top: 175px;
            left: 122px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 220px;
            left: 37px;
            z-index: 1;
            width: 76px;
        }
        .auto-style12 {
            position: absolute;
            top: 227px;
            left: 121px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 273px;
            left: 121px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 274px;
            left: 37px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 310px;
            left: 39px;
            z-index: 1;
            width: 79px;
        }
        .auto-style16 {
            position: absolute;
            top: 318px;
            left: 120px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 362px;
            left: 44px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 420px;
            left: 41px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 420px;
            left: 77px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtPhoneID" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="lblPhoneID" runat="server" CssClass="auto-style2" Text="Phone ID"></asp:Label>
        <asp:Label ID="lblPhoneName" runat="server" CssClass="auto-style3" Text="Phone Name"></asp:Label>
        <asp:TextBox ID="txtPhoneName" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Phone Manufacturer"></asp:Label>
        <asp:TextBox ID="txtPhoneManufacturer" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Label ID="lblBatteryCapacity" runat="server" CssClass="auto-style7" Text="Battery Capacity"></asp:Label>
        <asp:TextBox ID="txtBatteryCapacity" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:Label ID="lblCameraQuality" runat="server" CssClass="auto-style9" Text="Camera Quality"></asp:Label>
        <asp:TextBox ID="txtCameraQuality" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Label ID="lblStorageCapacity" runat="server" CssClass="auto-style11" Text="Storage Capacity"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtDisplaySize" runat="server" CssClass="auto-style13"></asp:TextBox>
        <asp:Label ID="lblDisplaySize" runat="server" CssClass="auto-style14" Text="Display Size"></asp:Label>
        <asp:Label ID="lblDateReleased" runat="server" CssClass="auto-style15" Text="Date Released"></asp:Label>
        <asp:TextBox ID="txtDateReleased" runat="server" CssClass="auto-style16"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style17"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style18" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style19" Text="Cancel" />
    </form>
</body>
</html>
