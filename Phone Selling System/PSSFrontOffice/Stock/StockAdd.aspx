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
            <%--<asp:TextBox ID="txtStockName" runat="server"></asp:TextBox>--%>
        </div>
        <div>
            <%--<asp:TextBox ID="txtWarehouseNo" runat="server"></asp:TextBox>--%>
        </div>
        <div>
            <%--<asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>--%>
        </div>
        <div>
            <%--<asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>--%>
        </div>
        <div>
            <%--<asp:TextBox ID="txtBarcode" runat="server"></asp:TextBox>--%>
        </div>
        
        <div>
            <%--<asp:Label ID="lblError" runat="server" Text=""></asp:Label>--%>
        </div>
        <div>
            <%--<asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />--%>
            <%--<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />--%>
        </div>






      

        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">

            <asp:Label ID="lblError" runat="server" Text="Error Label" Visible="False" BackColor="Red" BorderColor="Red" BorderStyle="Solid" Font-Names="Goudy Old Style" Font-Strikeout="False" Font-Underline="False" ToolTip="Error" Width="367px"></asp:Label>
        
                    </td>
                 
                </tr>
                <tr>
                    <td class="auto-style12">


        
            <asp:Label ID="lblStockName" runat="server" Text="StockName"></asp:Label>


        
                    </td>
                                        <td class="auto-style12">

                        <asp:TextBox ID="txtStockName" runat="server" TextMode="Password" ToolTip="Enter your pass" BorderColor="Blue" Height="34px" Width="369px"></asp:TextBox>

                    </td>
                </tr>
                <tr>

                    <td class="auto-style8">
            <asp:Label ID="lblWarehouseNo" runat="server" Text="WarehouseNo"></asp:Label>
                    </td>
                    <td class="auto-style9">

                        <asp:TextBox ID="txtWarehouseNo" runat="server" BorderColor="Blue" Height="34px" TextMode="Password" ToolTip="Enter your pass" Width="369px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
            <asp:Label ID="lblLocation" runat="server" Text="Location"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtLocation" runat="server" BorderColor="Blue" Height="34px" TextMode="Password" ToolTip="Enter your pass" Width="369px"></asp:TextBox>
                    </td>

                                     


                </tr>
                <tr>
                    <td class="auto-style5">
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
                    </td>
                                        <td class="auto-style11">
                        <asp:TextBox ID="txtQuantity" runat="server" BorderColor="Blue" Height="34px" TextMode="Password" ToolTip="Enter your pass" Width="369px"></asp:TextBox>
                    </td>
                    </tr>

                                <tr>
                    <td class="auto-style5">
            <asp:Label ID="lblBarcode" runat="server" Text="Barcode"></asp:Label>
                                    </td>
                                                        <td class="auto-style11">
                        <asp:TextBox ID="txtBarcode" runat="server" BorderColor="Blue" Height="34px" TextMode="Password" ToolTip="Enter your pass" Width="369px"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style5">
                                            <asp:Button ID="btnOK" runat="server" BorderColor="#990000" ForeColor="Red" OnClick="btnOK_Click" Text="OK" ToolTip="Adds Stock to database" Width="185px" />
                                                                                        <asp:Button ID="btnCancel" runat="server" BorderColor="#990000" ForeColor="Red" OnClick="btnCancel_Click" Text="Cancel" ToolTip="Proceed back to StockMain Page" Width="185px" />
                    </td>
                    </tr>
                <tr>
                                                                                <td class="auto-style5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Cancel</asp:HyperLink>
                    </td>
                    <td class="auto-style7">

                        &nbsp;</td>
                                       
                                        <td class="auto-style4">

                                            &nbsp;</td>
                </tr>
            </table>
        </div>










    </form>
</body>
</html>
