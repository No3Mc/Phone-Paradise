<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdmLogin.aspx.cs" Inherits="Stock_AdmLogin" %>

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
                        <asp:TextBox ID="user" runat="server" AutoCompleteType="Enabled" BorderColor="Blue" ToolTip="Please enter the username" Height="20px" Width="179px"></asp:TextBox>

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
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="185px" ToolTip="Logs into your account" BorderColor="#990000" ForeColor="Red" />
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
