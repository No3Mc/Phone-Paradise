<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneMain.aspx.cs" Inherits="Phone_PhoneMain" %>

<!DOCTYPE html>

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
            top: 116px;
            left: 256px;
            z-index: 1;
            width: 846px;
            height: 268px;
        }
        .auto-style2 {
            position: absolute;
            top: 429px;
            left: 323px;
            z-index: 1;
            width: 70px;
            }
        .auto-style3 {
            position: absolute;
            top: 430px;
            left: 430px;
            z-index: 1;
            width: 70px;
            }
        .auto-style4 {
            position: absolute;
            top: 430px;
            left: 537px;
            z-index: 1;
            width: 70px;
        }
        .auto-style5 {
            position: absolute;
            top: 430px;
            left: 633px;
            z-index: 1;
            width: 70px;
        }
        .auto-style6 {
            position: absolute;
            top: 429px;
            left: 737px;
            z-index: 1;
            width: 70px;
        }
        .auto-style7 {
            position: absolute;
            top: 429px;
            left: 838px;
            z-index: 1;
            width: 70px;
        }
        .auto-style8 {
            position: absolute;
            top: 430px;
            left: 940px;
            z-index: 1;
            width: 70px;
        }
        .auto-style9 {
            position: absolute;
            top: 500px;
            left: 334px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 482px;
            left: 480px;
            z-index: 1;
            width: 399px;
        }
        .auto-style11 {
            position: absolute;
            top: 29px;
            left: 550px;
            z-index: 1;
            width: 319px;
            height: 44px;
        }
        .auto-style12 {
            position: absolute;
            top: 17px;
            left: 22px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhone" runat="server" CssClass="auto-style1" Font-Names="Arial" OnSelectedIndexChanged="lstPhone_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" Font-Names="Arial" Text="Add" OnClick="btnAdd_Click" Font-Bold="True" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Font-Names="Arial" Text="Edit" OnClick="btnEdit_Click" Font-Bold="True" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" Font-Names="Arial" Text="Delete" OnClick="btnDelete_Click" Font-Bold="True" />
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style5" Font-Names="Arial" Text="Find" OnClick="btnFind_Click" Font-Bold="True" />
        <asp:Button ID="btnFilter" runat="server" CssClass="auto-style6" Text="Filter" OnClick="btnFilter_Click" Font-Bold="True" />
        <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style7" Font-Names="Arial" Text="Display" OnClick="btnDisplay_Click" Font-Bold="True" />
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style8" Font-Names="Arial" Text="Apply" OnClick="btnApply_Click" Font-Bold="True" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9" Font-Names="Arial" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtPhoneName" runat="server" CssClass="auto-style10" Font-Names="Arial"></asp:TextBox>
        <asp:Label ID="lblTitle" runat="server" BorderColor="Black" CssClass="auto-style11" Font-Bold="True" Font-Size="XX-Large"  ForeColor="White" Text="Phone Management" Font-Names="Arial"></asp:Label>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Names="Arial" OnClick="btnBack_Click" Text="Back to Admin Panel" />
    </form>
</body>
</html>
