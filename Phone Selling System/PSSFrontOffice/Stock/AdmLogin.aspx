<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdmLogin.aspx.cs" Inherits="Stock_AdmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href ="~/Stock/Styles/StyAdmLogin.css" rel ="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">

               <style>
            body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}

                   .auto-style1 {
                       position: absolute;
                       left: 515px;
                       top: 130px;
                   }
                   .auto-style2 {
                       position: absolute;
                       left: 516px;
                       top: 182px;
                   }
                   .auto-style3 {
                       position: absolute;
                       left: 519px;
                       top: 241px;
                   }
                   .auto-style4 {
                       position: absolute;
                       left: 648px;
                       top: 140px;
                   }
                   .auto-style5 {
                       position: absolute;
                       left: 648px;
                       top: 187px;
                   }

        </style>

                    &nbsp;<td class="auto-style4"><asp:TextBox ID="user" runat="server" BorderColor="Blue" ToolTip="Please enter the username" CssClass = "auto-style4" Height="20px" Width="179px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;<td class="auto-style4"><asp:TextBox ID="pass" runat="server" TextMode="Password" ToolTip="Enter your pass" CssClass = "auto-style5" BorderColor="Blue" Height="20px" Width="179px"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="185px" CssClass = "auto-style3" ToolTip="Logs into your account" BorderColor="#990000" ForeColor="Red" />
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

                    <asp:Label ID="Label1" runat="server" Text="Username" CssClass = "auto-style1"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Password" CssClass = "auto-style2"></asp:Label>


    </form>
</body>
</html>
