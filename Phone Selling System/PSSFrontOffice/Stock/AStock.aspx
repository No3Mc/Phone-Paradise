<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="_Default" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href ="~/Stock/Styles/StyAStock.css" rel ="stylesheet"/>
    <style type="text/css">
        
        .auto-style1 {
            position: absolute;
            left: 587px;
            top: 76px;
            right: 286px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <%--labels--%>
                    <asp:Label ID="lblStockID" runat="server" Text="Stock ID"  CssClass ="auto-style1"></asp:Label>
                    <asp:Label ID="lblWarehouseNo" runat="server" Text="Warehouse No" CssClass ="lblWarehouseNo" ></asp:Label>
                    <asp:Label ID="lblStockName" runat="server" Text="Stock Name" CssClass ="lblStockName"></asp:Label>
                    <asp:Label ID="lblLocation" runat="server" Text="Location" CssClass ="lblLocation"></asp:Label>
                    <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass ="lblQuantity"></asp:Label>
                    <asp:Label ID="lblBarcode" runat="server" Text="Barcode" CssClass ="lblBarcode"></asp:Label>
                    <asp:Label ID="lblError" runat="server" Text="lblError" CssClass ="lblError"></asp:Label>
        <%--textboxes--%>
                    <asp:TextBox ID="txtStockID" runat="server" CssClass ="txtStockID"></asp:TextBox>
                    <asp:TextBox ID="txtStockname" runat="server" CssClass ="txtStockname"></asp:TextBox>
                    <asp:TextBox ID="txtLocation" runat="server" CssClass ="txtLocation"></asp:TextBox>
                    <asp:TextBox ID="txtWarehouseNo" runat="server" CssClass ="txtWarehouseNo"></asp:TextBox>
                    <asp:TextBox ID="txtQuantity" runat="server" CssClass ="txtQuantity"></asp:TextBox>
                    <asp:TextBox ID="txtBarcode" runat="server" CssClass ="txtBarcode"></asp:TextBox>
        <%--buttons--%>
                    <asp:Button ID="btnOK" runat="server" Text="Okay" OnClick="btnOK_Click1" CssClass ="btnOK" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass ="btnCancel"/>
                    <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass ="btnFind"/>
        <%--list--%>
                    <asp:ListBox ID="lstStocks" runat="server" CssClass ="lstStocks" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged"></asp:ListBox>


    </form>
</body>
</html>
