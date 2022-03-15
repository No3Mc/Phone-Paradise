<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
        <asp:Button ID="Button1" runat="server" Text="Company Logo" Height="54px" Width="194px" />
                    </td>
                    <td class="auto-style1"></td>
                    <td>
        <asp:Button ID="Button2" runat="server" Text="Edit Sales" />
        <asp:Button ID="Button3" runat="server" Text="Edit Location" />
        <asp:Button ID="Button4" runat="server" Text="Edit Phones" />
                    </td>
                </tr>
            </table>
        </div>
        <div></div>
                <div>
        <asp:Button ID="Button5" runat="server" Text="Management Panel" Height="63px" Width="302px" />
        </div>
                <div></div>
                        <div>
        <asp:Button ID="Button6" runat="server" Text="Stock Management" Width="175px" OnClick="Button6_Click" />
        </div>
                        <div>
        <asp:Button ID="Button7" runat="server" Text="Product Management" Width="175px" />
        </div>
                        <div>
        <asp:Button ID="Button8" runat="server" Text="Staff Management" Width="175px" />
        </div>
                        <div>
        <asp:Button ID="Button9" runat="server" Text="Customer Management"  Width="175px" />
        </div>
                        <div>
        <asp:Button ID="Button10" runat="server" Text="Order Management" Width="175px"  />
        </div>
    </form>
</body>
</html>
