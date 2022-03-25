<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="_Default" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href ="~/Stock/Styles/StyAStock.css" rel ="stylesheet"/>
    <style type="text/css">
                            body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}
                
        .auto-style3 {
            position: absolute;
            left: 244px;
            top: 53px;
            right: 1481px;
            border-radius: 10px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 35px;
            width: 93px;
        }
        
        .auto-style4 {
            position: absolute;
            left: 587px;
            top: 50px;
            right: 1122px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 37px;
            width: 109px;
        }
        .auto-style5 {
            position: absolute;
            left: 574px;
            top: 114px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 27px;
            bottom: 240px;
        }
        .auto-style6 {
            position: absolute;
            left: 563px;
            top: 163px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
        }
        .auto-style7 {
            position: absolute;
            left: 589px;
            top: 197px;
            right: 1160px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 30px;
        }
        .auto-style8 {
            position: absolute;
            left: 592px;
            top: 234px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 28px;
        }
        .auto-style9 {
            position: absolute;
            left: 592px;
            top: 278px;
            margin-top: 3px;
            border-radius: 16px;
            text-align: center;
            background-color: wheat;
            text-shadow: 1px 1px;
            height: 31px;
        }
        .auto-style10 {
            position: absolute;
            left: 237px;
            top: 104px;
            width: 303px;
            height: 284px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <%--labels--%>
                    <asp:Label ID="Label1" runat="server" Text="Stock ID"  CssClass ="auto-style3"></asp:Label>


                    <asp:Label ID="lblStockID" runat="server" Text="Stock ID"  CssClass ="auto-style4"></asp:Label>
                    <asp:Label ID="lblWarehouseNo" runat="server" Text="Warehouse No" CssClass ="auto-style6" ></asp:Label>
                    <asp:Label ID="lblStockName" runat="server" Text="Stock Name" CssClass ="auto-style5"></asp:Label>
                    <asp:Label ID="lblLocation" runat="server" Text="Location" CssClass ="auto-style7"></asp:Label>
                    <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass ="auto-style8"></asp:Label>
                    <asp:Label ID="lblBarcode" runat="server" Text="Barcode" CssClass ="auto-style9"></asp:Label>
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
                    <asp:ListBox ID="lstStocks" runat="server" CssClass ="auto-style10" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged"></asp:ListBox>


    </form>
</body>
</html>
