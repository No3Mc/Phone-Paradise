<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierMain.aspx.cs" Inherits="Supplier_SupplierMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 552px;
        }
        .auto-style4 {
            margin-left: 159px;
        }
        .auto-style6 {
            margin-left: 161px;
        }
        .auto-style7 {
            margin-left: 138px;
        }
    </style>
</head>
<body style="width: 569px; height: 666px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Supplier Main Page"></asp:Label>
        </div>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Height="262px" Width="550px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="[IblError]"></asp:Label>
        </p>
        <p class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="Please Enter a SupplierID"></asp:Label>
        </p>
        <p class="auto-style3">
            <asp:TextBox ID="TextBox1" runat="server" Width="261px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="30px" OnClick="btnAdd_Click" Text="Add" Width="111px" />
            <asp:Button ID="btnUpdate" runat="server" CssClass="auto-style6" Height="29px" OnClick="btnUpdate_Click" Text="Update" Width="111px" />
        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" Height="28px" OnClick="btnDelete_Click" Text="Delete" Width="111px" />
            <asp:Button ID="SFind" runat="server" CssClass="auto-style4" Height="32px" OnClick="SFind_Click" Text="Find" Width="114px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdminPanel" runat="server" CssClass="auto-style7" OnClick="btnAdminPanel_Click" Text="Admin Panel" Width="96px" />
        </p>
    </form>
</body>
</html>
