<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockAdd.aspx.cs" Inherits="Stock_StockAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div>

                    <asp:Label ID="Label1" runat="server" Text="Stock Name"></asp:Label>
                    <asp:TextBox ID="txtStockName" runat="server"></asp:TextBox>

        </div>

                <div>
                    
        </div>

        
                <div>
                    
                    <asp:Label ID="Label3" runat="server" Text="Warehouse No"></asp:Label>
                    <asp:TextBox ID="txtWarehouseNo" runat="server"></asp:TextBox>

        </div>

        
                <div>
                    
                    <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
                    <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>

        </div>

        
                <div>
                    
                    <asp:Label ID="Label5" runat="server" Text="Quantity"></asp:Label>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>

        </div>

                        <div>
                    
                    <asp:Label ID="Label6" runat="server" Text="Barcode"></asp:Label>
                    <asp:TextBox ID="txtBarcode" runat="server"></asp:TextBox>

        </div>

        
                <div>
                    <asp:Button ID="btnOK" runat="server" Text="Okay" OnClick="btnOK_Click1" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>


        <div>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        
        </div>

                <div>
<%--            <asp:ListBox ID="lstStocks" runat="server" Height="300px" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged" Width="517px"></asp:ListBox>--%>
        </div>
    </form>
</body>
</html>
