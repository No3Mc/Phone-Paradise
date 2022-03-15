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
                                <%--Taken from :https://www.renaultgroup.com/--%>
                                <asp:ImageButton ID="ImageButton15" runat="server" Height="69px" ImageUrl="~/Images/Logo/Logo.jpg" Width="195px" OnClick="ImageButton15_Click" />
                    </td>
                    <td class="auto-style1" Height="20px" Width="302px"></td>
                    <td>
        <asp:Button ID="Button2" runat="server" Text="Edit Sales" />
        <asp:Button ID="Button3" runat="server" Text="Edit Location" />
        <asp:Button ID="Button4" runat="server" Text="Edit Phones" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table>
                <tr>
                    <td Height="20px" Width="302px" >    </td>
                </tr>
            </table>
        </div>
                <div>
        <asp:Button ID="Button5" runat="server" Text="Management Panel" Height="63px" Width="302px" />
        </div>
                <div>
                    <table>
                        <tr>
                            <td Height="20px" Width="302px">

                            </td>
                        </tr>
                    </table>
                </div>
                        <div>
        <asp:Button ID="Button6" runat="server" Text="Stock Management" Width="175px" OnClick="Button6_Click" />
        </div>
                            <table>
                        <tr>
                            <td Height="20px" Width="302px">

                            </td>
                        </tr>
                    </table>
                        <div>
        <asp:Button ID="Button7" runat="server" Text="Product Management" Width="175px" />
        </div>
                            <table>
                        <tr>
                            <td Height="20px" Width="302px">

                            </td>
                        </tr>
                    </table>
                        <div>
        <asp:Button ID="Button8" runat="server" Text="Staff Management" Width="175px" />
        </div>
                            <table>
                        <tr>
                            <td Height="20px" Width="302px">

                            </td>
                        </tr>
                    </table>
                        <div>
        <asp:Button ID="Button9" runat="server" Text="Customer Management"  Width="175px" />
        </div>
                            <table>
                        <tr>
                            <td Height="20px" Width="302px">

                            </td>
                        </tr>
                    </table>
                        <div>
        <asp:Button ID="Button10" runat="server" Text="Order Management" Width="175px"  />
        </div>
    </form>
</body>
</html>
