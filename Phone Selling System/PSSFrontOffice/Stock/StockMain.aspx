<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockMain.aspx.cs" Inherits="Stock_StockMain" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="~/Stock/Styles/StyStockMain.css" rel ="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
        
        <style>
            body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}







        </style>
        
        
         <%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>


                                                                                 









            <table class="table">
                <tr>
                    <td >&nbsp;</td>
                    <td ><asp:Label ID="lblEnter" runat="server" Text="Please enter Warehouse No" CssClass ="lblEnter"></asp:Label>
                    </td>
                 
                </tr>
                <tr>
                    <td >


        
                    </td>
                                        <td>

            <asp:Label ID="lblError" runat="server" class="labels" Text="Error Label" Visible="False" BackColor="Red" BorderColor="Red" BorderStyle="Solid" Font-Names="Goudy Old Style" Font-Strikeout="False" Font-Underline="False" ToolTip="Error" ></asp:Label>
        
                    </td>
                </tr>
                <tr>

                    <td ></td>
                    <td >

                        <asp:TextBox ID="txtWarehouseNo" runat="server" ToolTip="Enter your pass" BorderColor="Blue" Height="34px" Width="369px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Apply" Width="185px" OnClick="btnApply_Click" ToolTip="Filters requested Stocks" BorderColor="#990000" ForeColor="Red" />
                        <asp:Button ID="Button2" runat="server" Text="Display All" Width="185px" OnClick="btnDisplayAll_Click" ToolTip="Displays All Stocks" BorderColor="#990000" ForeColor="Red" />

                        <asp:Button ID="Button5" runat="server" Text="Delete" Width="186px" OnClick="btnDelete_Click" ToolTip="Delete Stocks" BorderColor="#990000" ForeColor="Red" CssClass="auto-style6" />

                    </td>

                                     


                </tr>
                <tr>
                    <td>&nbsp;</td>
                    </tr>
                <tr>
                                                                                <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Cancel</asp:HyperLink>
                    </td>
                    <td >

                        <asp:Button ID="Button3" runat="server" Text="Add" Width="185px" OnClick="btnAdd_Click" ToolTip="Add Stocks" BorderColor="#990000" ForeColor="Red" />

                        <asp:Button ID="Button4" runat="server" Text="Edit" Width="185px" OnClick="btnEdit_Click" ToolTip="Edit Stocks" BorderColor="#990000" ForeColor="Red" />

                                                                                </td>
                                       
                                        <td>

                                                                                </td>
                </tr>
            </table>



























                                <asp:ListBox ID="lstWarehouseNo" runat="server" CssClass="lstWarehouseNo" ></asp:ListBox>
                                <asp:ListBox ID="lstStockName" runat="server" CssClass="lstStockName"></asp:ListBox>
                                <asp:ListBox ID="lstQuantity" runat="server" CssClass="lstQuantity"></asp:ListBox>
                                <asp:ListBox ID="lstBarcode" runat="server" CssClass="lstBarcode"></asp:ListBox>
                                <asp:ListBox ID="lstLocation" runat="server" CssClass="lstLocation"></asp:ListBox>

















































                <asp:Label ID="lblStockName" runat="server" Text="StockName" CssClass="lblStockName"></asp:Label>
                <asp:Label ID="lblQuantity" runat="server" Text="Quantity" CssClass="lblQuantity"></asp:Label>
                <asp:Label ID="lblWarehouseNo" runat="server" Text="WarehouseNo" CssClass="lblWarehouseNo"></asp:Label>
                <asp:Label ID="lblLocation" runat="server" Text="Location" CssClass="lblLocation"></asp:Label>
                <asp:Label ID="lblBarcode" runat="server" Text="Barcode" CssClass="lblBarcode"></asp:Label>
























        <p>
























        <asp:Button ID="btnLogout" runat="server" Text="Logout"  CssClass="btnLogout" OnClick="btnLogout_Click"/>
























        </p>
























    </form>
</body>
</html>
