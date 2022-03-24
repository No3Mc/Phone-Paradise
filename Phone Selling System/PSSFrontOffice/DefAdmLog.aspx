<%--Written by Syed, Ethan, Talha, Luke, and Aqeel || P2652259|| Syed/No3Mc(https://github.com/No3Mc),  P2596393 || Ethan/Frizzle15(https://github.com/Frizzle15), P2629099 || Talha(https://github.com/Talhamemon25), P2606530 || Luke/LLydiatt(https://github.com/LLydiatt)and Aqeel(https://github.com/AqeelAhmed12))

Stock Management by Syed Naqvi
Staff Management by Luke Lydiatt
Phones Management by Ethan Frizzell
Customer Management by Mahammad Talha
Supplier management by Aqeel Ahmed	


Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefAdmLog.aspx.cs" Inherits="DefAdmLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style3">Enter login details</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style6">Username</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="user" runat="server"  BorderColor="Blue" ToolTip="Please enter the username" Height="20px" Width="179px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="pass" runat="server" TextMode="Password" ToolTip="Enter your pass" BorderColor="Blue" Height="20px" Width="179px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" Text="Login" Width="185px" ToolTip="Logs into your account" BorderColor="#990000" ForeColor="Red" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Cancel</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>


    </form>
</body>
</html>
