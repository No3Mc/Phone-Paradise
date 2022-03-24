<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneAdd.aspx.cs" Inherits="Phone_PhoneAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 176px;
            left: 236px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 177px;
            left: 324px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 213px;
            left: 238px;
            z-index: 1;
            width: 85px;
        }
        .auto-style4 {
            position: absolute;
            top: 222px;
            left: 324px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 266px;
            left: 239px;
            z-index: 1;
            width: 76px;
        }
        .auto-style6 {
            position: absolute;
            top: 272px;
            left: 324px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 323px;
            left: 241px;
            z-index: 1;
            width: 75px;
        }
        .auto-style8 {
            position: absolute;
            top: 326px;
            left: 323px;
            z-index: 1;
            margin-top: 0px;
        }
        .auto-style9 {
            position: absolute;
            top: 374px;
            left: 242px;
            z-index: 1;
            width: 71px;
        }
        .auto-style10 {
            position: absolute;
            top: 377px;
            left: 324px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 430px;
            left: 240px;
            z-index: 1;
            width: 64px;
        }
        .auto-style12 {
            position: absolute;
            top: 431px;
            left: 325px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 486px;
            left: 321px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 486px;
            left: 241px;
            z-index: 1;
            width: 60px;
        }
        .auto-style15 {
            position: absolute;
            top: 488px;
            left: 518px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 548px;
            left: 270px;
            z-index: 1;
            width: 70px;
        }
        .auto-style17 {
            position: absolute;
            top: 548px;
            left: 344px;
            z-index: 1;
            width: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblPhoneName" runat="server" CssClass="auto-style1" Text="Phone Name"></asp:Label>
        <asp:TextBox ID="txtPhoneName" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblPhoneManufacturer" runat="server" CssClass="auto-style3" Text="Phone Manufacturer"></asp:Label>
        <asp:TextBox ID="txtPhoneManufacturer" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="lblBatteryCapacity" runat="server" CssClass="auto-style5" Text="Battery Capacity"></asp:Label>
        <asp:TextBox ID="txtBatteryCapacity" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Label ID="lblCameraQuality" runat="server" CssClass="auto-style7" Text="Camera Quality"></asp:Label>
        <asp:TextBox ID="txtCameraQuality" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:Label ID="lblStorageCapacity" runat="server" CssClass="auto-style9" Text="Storage Capacity"></asp:Label>
        <asp:TextBox ID="txtStorageCapacity" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Label ID="lblDisplaySize" runat="server" CssClass="auto-style11" Text="Display Size"></asp:Label>
        <asp:TextBox ID="txtDisplaySize" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtDateReleased" runat="server" CssClass="auto-style13"></asp:TextBox>
        <asp:Label ID="lblDateReleased" runat="server" CssClass="auto-style14" Text="Date Released"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style16" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style17" Text="Cancel" />
    </form>
</body>
</html>
