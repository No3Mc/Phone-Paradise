<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 

        <asp:ListBox ID="lstStocks" runat="server" Height="332px" Width="791px"></asp:ListBox>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Modify" Height="54px" Width="132px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
 

    </form>
</body>
</html>
