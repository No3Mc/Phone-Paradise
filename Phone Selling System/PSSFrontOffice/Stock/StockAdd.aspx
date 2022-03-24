<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockAdd.aspx.cs" Inherits="Stock_StockAdd" %>

<!DOCTYPE html>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="~/Stock/Styles/StyStockAdd.css" rel ="stylesheet"/>

    <style type="text/css">

        .auto-style14 {
            position: absolute;
            left: 302px;
            top: 111px;
            bottom: 655px;
        }
        
        .auto-style15 {
            position: absolute;
            left: 303px;
            top: 173px;
        }
        .auto-style16 {
            position: absolute;
            left: 284px;
            top: 370px;
        }
        .auto-style17 {
            position: absolute;
            left: 307px;
            top: 234px;
        }
        .auto-style18 {
            position: absolute;
            left: 307px;
            top: 297px;
        }
        .auto-style19 {
            position: absolute;
            Height: 34px;
            Width: 369px;
            border-block-color: Blue;
            left: 455px;
            top: 110px;
        }
        .auto-style20 {
            position: absolute;
            Height: 34px;
            Width: 369px;
            border-block-color: Blue;
            left: 456px;
            top: 172px;
        }
        .auto-style21 {
            position: absolute;
            Height: 34px;
            Width: 369px;
            border-block-color: Blue;
            left: 458px;
            top: 298px;
        }
        .auto-style22 {
            position: absolute;
            Height: 34px;
            Width: 369px;
            border-block-color: Blue;
            left: 458px;
            top: 369px;
        }
        .auto-style23 {
            position: absolute;
            background-color: Red;
            border-color: Red;
            border-style: Solid;
            Width: 542px;
            left: 856px;
            top: 110px;
            height: 92px;
        }
        .auto-style24 {
            position: absolute;
            Height: 34px;
            Width: 369px;
            border-block-color: Blue;
            left: 456px;
            top: 237px;
        }
        .auto-style25 {
            position: absolute;
            border-block-color: #990000;
            color: Red;
            Width: 185px;
            left: 452px;
            top: 438px;
        }
        .auto-style26 {
            position: absolute;
            border-block-color: #990000;
            color: Red;
            Width: 185px;
            left: 647px;
            top: 438px;
        }
        
        .auto-style27 {
            position: absolute;
            left: 858px;
            top: 237px;
        }
        
    </style>

</head>
<body>
    <form id="form1" runat="server">


<%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>
      





        
                        <asp:Label ID="lblStockName" runat="server" Text="StockName" CssClass ="lblStockName"></asp:Label>
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
