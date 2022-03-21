<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockMain.aspx.cs" Inherits="Stock_StockMain" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href ="~/Stock/Styles/StyStockMain.css" rel ="stylesheet"/>

    <style type="text/css">

    </style>
</head>
<body>
    <form id="form1" runat="server">
        
                <div>
                    
        </div>
        
                <div>
                    <table>

                                            <tr>

                    </tr>

                    </table>

        </div>

         <%--For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode--%>
         <div class="auto-style1"> 

                                <asp:ListBox ID="lstStockName" runat="server" CssClass="labels" ></asp:ListBox>
                                <asp:ListBox ID="lstWarehouseNo" runat="server" CssClass="labels" ></asp:ListBox>
                                <asp:ListBox ID="lstLocation" runat="server" CssClass="labels" ></asp:ListBox>
                                <asp:ListBox ID="lstQuantity" runat="server" CssClass="labels" ></asp:ListBox>
                                <asp:ListBox ID="lstBarcode" runat="server" CssClass="labels" ></asp:ListBox>
             </div>



                <div>
                    
        </div>

        
                <div>
                                <%--            <asp:ListBox ID="lstStocks" runat="server" Height="300px" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged" Width="517px"></asp:ListBox>--%>
                                <%--<asp:Button ID="btnAdd" runat="server" Text="Add" Width="44px" OnClick="btnAdd_Click" />--%>
                                <%--<asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />--%>
                                <%--<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />--%>
        </div>











        <div class = "StockAdminbox">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">Please enter Warehouse No</td>
                 
                </tr>
                <tr>
                    <td class="auto-style12">


        
                    </td>
                                        <td class="auto-style12">

            <asp:Label ID="lblError" runat="server" Text="Error Label" Visible="False" BackColor="Red" BorderColor="Red" BorderStyle="Solid" Font-Names="Goudy Old Style" Font-Strikeout="False" Font-Underline="False" ToolTip="Error" Width="367px"></asp:Label>
        
                    </td>
                </tr>
                <tr>

                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">

                        <asp:TextBox ID="txtWarehouseNo" runat="server" TextMode="Password" ToolTip="Enter your pass" BorderColor="Blue" Height="34px" Width="369px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">
                        <asp:Button ID="Button1" runat="server" Text="Apply" Width="185px" OnClick="btnApply_Click" ToolTip="Logs into your account" BorderColor="#990000" ForeColor="Red" />
                        <asp:Button ID="Button2" runat="server" Text="Display All" Width="185px" OnClick="btnDisplayAll_Click" ToolTip="Logs into your account" BorderColor="#990000" ForeColor="Red" />
                    </td>

                                     


                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    </tr>
                <tr>
                                                                                <td class="auto-style5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Cancel</asp:HyperLink>
                    </td>
                    <td class="auto-style7">

                        <asp:Button ID="Button3" runat="server" Text="Add" Width="185px" OnClick="btnAdd_Click" ToolTip="Add Stocks" BorderColor="#990000" ForeColor="Red" />

                        <asp:Button ID="Button4" runat="server" Text="Edit" Width="185px" OnClick="btnEdit_Click" ToolTip="Edit Stocks" BorderColor="#990000" ForeColor="Red" />

                                                                                </td>
                                       
                                        <td class="auto-style4">

                        <asp:Button ID="Button5" runat="server" Text="Delete" Width="221px" OnClick="btnDelete_Click" ToolTip="Delete Stocks" BorderColor="#990000" ForeColor="Red" CssClass="auto-style6" />

                                                                                </td>
                </tr>
            </table>
        </div>


























    </form>
</body>
</html>
