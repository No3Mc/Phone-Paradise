<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PhoneMain.aspx.cs" Inherits="Phone_PhoneMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
            right: 1117px;
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
            top: 509px;
            left: 328px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 500px;
            left: 479px;
            z-index: 1;
            width: 399px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPhone" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="lstPhone_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style5" Text="Find" OnClick="btnFind_Click" />
        <asp:Button ID="btnFilter" runat="server" CssClass="auto-style6" Text="Filter" OnClick="btnFilter_Click" />
        <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style7" Text="Display" OnClick="btnDisplay_Click" />
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style8" Text="Apply" OnClick="btnApply_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9"></asp:Label>
        <asp:TextBox ID="txtPhoneName" runat="server" CssClass="auto-style10"></asp:TextBox>
    </form>
</body>
</html>
