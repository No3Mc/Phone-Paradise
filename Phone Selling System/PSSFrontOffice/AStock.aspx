<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

                <div>

                    <asp:Label ID="Label1" runat="server" Text="Stock Name"></asp:Label>
                    <asp:TextBox ID="txtStockname" runat="server"></asp:TextBox>

                    <asp:Button ID="btnFind" runat="server" Text="Find" />

        </div>

                <div>
                    
                    <asp:Label ID="Label2" runat="server" Text="Stock ID"></asp:Label>
                    <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>

        </div>

        
                <div>
                    
                    <asp:Label ID="Label3" runat="server" Text="Warehouse No"></asp:Label>
                    <asp:TextBox ID="txtWarehouseno" runat="server"></asp:TextBox>

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





    </form>
</body>
</html>
