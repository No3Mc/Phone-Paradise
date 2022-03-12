<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockAdd.aspx.cs" Inherits="Stock_StockAdd" %>

<!DOCTYPE html>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div>

<%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>
        <div>
            <asp:Label ID="lblStockName" runat="server" Text="StockName"></asp:Label>
            <asp:TextBox ID="txtStockName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblWarehouseNo" runat="server" Text="WarehouseNo"></asp:Label>
            <asp:TextBox ID="txtWarehouseNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblBarcode" runat="server" Text="Barcode"></asp:Label>
            <asp:TextBox ID="txtBarcode" runat="server"></asp:TextBox>
        </div>
        
        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
