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
            left: 249px;
            top: 109px;
            margin-top: 3px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            width: 182px;
            height: 301px;
        }
        
        .auto-style3 {
            position: absolute;
            width: 1220px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 103px;
            top: 492px;
            height: 194px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        
        .auto-style4 {
            position: absolute;
            width: 688px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 842px;
            top: 103px;
            height: 40px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        
        .auto-style5 {
            position: absolute;
            width: 688px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 847px;
            top: 362px;
            height: 40px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        
        .auto-style6 {
            position: absolute;
            width: 688px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 841px;
            top: 162px;
            height: 40px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        .auto-style7 {
            position: absolute;
            left: 279px;
            top: 51px;
        }
        
        .auto-style8 {
            position: absolute;
            width: 688px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 842px;
            top: 226px;
            height: 40px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        
        .auto-style9 {
            position: absolute;
            width: 688px;
            text-align: center;
            text-shadow: 1px 1px;
            left: 848px;
            top: 291px;
            height: 40px;
            border-style: Solid;
            border-color: Red;
            margin-top: 3px;
            background-color: wheat;
        }
        .auto-style10 {
            position: absolute;
            left: 303px;
            top: 173px;
            margin-top: 3px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 30px;
        }
        .auto-style11 {
            position: absolute;
            left: 307px;
            top: 234px;
            margin-top: 3px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 33px;
        }
        .auto-style12 {
            position: absolute;
            left: 307px;
            top: 297px;
            margin-top: 3px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 29px;
        }
        .auto-style13 {
            position: absolute;
            left: 284px;
            top: 370px;
            margin-top: 3px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 33px;
        }
        
    </style>

</head>
<body>
    <form id="form1" runat="server">

<%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>
      
        
                        <asp:Label ID="lblStockName" runat="server" Text="StockName" CssClass ="auto-style2"></asp:Label>
                        <asp:Label ID="lblWarehouseNo" runat="server" Text="WarehouseNo" CssClass ="auto-style13"></asp:Label>
                        <asp:Label ID="lblLocation" runat="server" Text="Location" CssClass ="auto-style10"></asp:Label>
                        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass ="auto-style11"></asp:Label>
                        <asp:Label ID="lblBarcode" runat="server" Text="Barcode" CssClass ="auto-style12"></asp:Label>

                        <asp:TextBox ID="txtStockName" runat="server"   CssClass ="txtStockName" ToolTip="Enter Stock Name" ></asp:TextBox>
                        <asp:TextBox ID="txtWarehouseNo" runat="server"  CssClass ="txtWarehouseNo" ToolTip="Enter Warehouse No" ></asp:TextBox>
                        <asp:TextBox ID="txtLocation" runat="server" CssClass ="txtLocation"  ToolTip="Enter Location" ></asp:TextBox>
                        <asp:TextBox ID="txtQuantity" runat="server" CssClass ="txtQuantity"  ToolTip="Enter Quantity"></asp:TextBox>
                        <asp:TextBox ID="txtBarcode" runat="server" CssClass ="txtBarcode" ToolTip="Enter Barcode" ></asp:TextBox>

                        <asp:Button ID="btnCancel" runat="server" CssClass ="btnCancel"  OnClick="btnCancel_Click" Text="Cancel" ToolTip="Proceed back to StockMain Page" />
                        <asp:Button ID="btnOK" runat="server"  CssClass ="btnOK" OnClick="btnOK_Click" Text="OK" ToolTip="Adds Stock to database" />

                        <asp:Label ID="StocklblError" runat="server" CssClass="auto-style4" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>
                        <asp:Label ID="warehnolblError" runat="server" CssClass="auto-style5" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>
                        <asp:Label ID="localblError" runat="server" CssClass="auto-style6" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>
                        <asp:Label ID="qualilblError" runat="server" CssClass="auto-style8" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>
                        <asp:Label ID="barclblError" runat="server" CssClass="auto-style9" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>

                        <asp:Label ID="lblError" runat="server" CssClass="auto-style3" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>


                        <asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Default.aspx" CssClass="auto-style7" BackColor="Black" >Main Page</asp:HyperLink>



    </form>
</body>
</html>
