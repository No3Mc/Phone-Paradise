<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockMain.aspx.cs" Inherits="Stock_StockMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>

                                <asp:ListBox ID="lstStocks" runat="server" Height="300px" Width="517px"></asp:ListBox>

        </div>

                <div>
                    
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        
        </div>

        
                <div>
                    
        </div>

        
                <div>
                    
                    <asp:Label ID="Label1" runat="server" Text="Please enter a warehouse no"></asp:Label>

        </div>

        
                <div>
                    
                    <asp:TextBox ID="txtWarehouseNo" runat="server" Width="214px"></asp:TextBox>

        </div>

                        <div>
                    
        </div>

        
                <div>

                    <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
                    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" />
        </div>


        <div>
        
        </div>

                <div>
                                <%--            <asp:ListBox ID="lstStocks" runat="server" Height="300px" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged" Width="517px"></asp:ListBox>--%>
                                <asp:Button ID="btnAdd" runat="server" Text="Add" Width="44px" OnClick="btnAdd_Click" />
                                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
