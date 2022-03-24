<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Custpg.aspx.cs" Inherits="Customer_Custpg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>

                                <asp:ListBox ID="lstCust" runat="server" Height="300px" Width="517px"></asp:ListBox>

        </div>

                <div>
                    
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        
        </div>

        
                <div>
                    
                    <asp:Label ID="Label1" runat="server" Text="Please Enter the Phone No"></asp:Label>

        </div>

        
                <div>
                    
                    <asp:TextBox ID="txtWarehouseNo" runat="server" Width="214px"></asp:TextBox>

        </div>


        
                <div>

                    <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
                    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        </div>


        <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="44px" OnClick="btnAdd_Click" />
                                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" style="height: 29px" />
                                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>

    
    </form>
</body>
</html>
