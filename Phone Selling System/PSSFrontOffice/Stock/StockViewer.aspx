<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="StockViewer" %>
<%--Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link href ="~/Stock/Styles/StyStockViewer.css" rel ="stylesheet"/>
    <style type="text/css">
          body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}

        .auto-style1 {
            position: absolute;
            left: 571px;
            top: 158px;
            height: 294px;
            width: 710px;
        }
        .auto-style2 {
            position: absolute;
            left: 421px;
            top: 315px;
            width: 126px;
        }
        .auto-style3 {
            position: absolute;
            left: 424px;
            top: 230px;
            width: 122px;
            height: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
 

        <asp:ListBox ID="lstStocks" runat="server" CssClass ="auto-style1"></asp:ListBox>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Modify" Height="54px" CssClass ="auto-style2" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
 

        <asp:Button ID="btnBack" runat="server" Text="<< Back"  CssClass ="auto-style3" OnClick="btnBack_Click"/>
 

    </form>
</body>
</html>
