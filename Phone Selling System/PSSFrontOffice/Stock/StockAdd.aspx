<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockAdd.aspx.cs" Inherits="Stock_StockAdd" %>

<!DOCTYPE html>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="~/Stock/Styles/StyStockAdd.css" rel ="stylesheet"/>

    <style type="text/css">

                            body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}
        
        .auto-style2 {
            position: absolute;
            left: 301px;
            top: 120px;
            bottom: 235px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
        }
        
    </style>

</head>
<body>
    <form id="form1" runat="server">

<%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>
      
        
                        <asp:Label ID="lblStockName" runat="server" Text="StockName" CssClass ="auto-style2"></asp:Label>
                        <asp:Label ID="lblWarehouseNo" runat="server" Text="WarehouseNo" CssClass ="lblWarehouseNo"></asp:Label>
                        <asp:Label ID="lblLocation" runat="server" Text="Location" CssClass ="lblLocation"></asp:Label>
                        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass ="lblQuantity"></asp:Label>
                        <asp:Label ID="lblBarcode" runat="server" Text="Barcode" CssClass ="lblBarcode"></asp:Label>

                        <asp:TextBox ID="txtStockName" runat="server"   CssClass ="txtStockName" ToolTip="Enter Stock Name" ></asp:TextBox>
                        <asp:TextBox ID="txtWarehouseNo" runat="server"  CssClass ="txtWarehouseNo" ToolTip="Enter Warehouse No" ></asp:TextBox>
                        <asp:TextBox ID="txtLocation" runat="server" CssClass ="txtLocation"  ToolTip="Enter Location" ></asp:TextBox>
                        <asp:TextBox ID="txtQuantity" runat="server" CssClass ="txtQuantity"  ToolTip="Enter Quantity"></asp:TextBox>
                        <asp:TextBox ID="txtBarcode" runat="server" CssClass ="txtBarcode" ToolTip="Enter Barcode" ></asp:TextBox>

                        <asp:Button ID="btnCancel" runat="server" CssClass ="btnCancel"  OnClick="btnCancel_Click" Text="Cancel" ToolTip="Proceed back to StockMain Page" />
                        <asp:Button ID="btnOK" runat="server"  CssClass ="btnOK" OnClick="btnOK_Click" Text="OK" ToolTip="Adds Stock to database" />

                        <asp:Label ID="lblError" runat="server" CssClass="lblError" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>

                        <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Default.aspx" CssClass="HyperLinkCancel" >Main Page</asp:HyperLink>



    </form>
</body>
</html>
