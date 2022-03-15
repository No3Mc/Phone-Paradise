<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 170px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            width: 1001px;
            height: 155px;
        }
        .auto-style5 {
            width: 129px;
        }
        .auto-style6 {
            width: 55px;
        }
        .auto-style7 {
            width: 815px;
            height: 406px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">


        <div>
            </div>
        <div></div>
                <div>
                    <table class="auto-style4">
                        <tr>
                            <td>
                                <%--Taken from :https://www.renaultgroup.com/--%>
                                <asp:ImageButton ID="ImageButton15" runat="server" Height="69px" ImageUrl="~/Images/Logo/Logo.jpg" Width="195px" />
                                                                </td>
                            <td class="auto-style6">
                                <asp:Button ID="Button6" runat="server" Text="Sales" />
                                                                </td>
                            <td class="auto-style5">
                                <asp:Button ID="Button7" runat="server" Text="Location" Width="131px" />
                                                                </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="Button8" runat="server" Text="Shop Phones" />
                                                                </td>
                            <tr>
                                <td></td>
                            </tr>
                            <td></td>
                            <td class="auto-style6"></td>
                            <td class="auto-style5"></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>&nbsp;</td>

                            <td>
                                <asp:Button ID="Button9" runat="server" Text="Signin" />
                                </td>
                            <td></td>
                                <td class="auto-style3">

                                    <asp:Button ID="Button10" runat="server" Text="Adm Login" OnClick="Button10_Click" />

                                </td>
                            </table>
            </div>
        <div>  </div>
                        <div>
                            <table class="auto-style7">
                                <tr>
                                    <td rowspan ="2">
                                        <asp:Button ID="Button11" runat="server" Height="388px" Text="Selection" Width="136px" />
                                        </td>
                                    <td class="auto-style2">
                                                                                                            <asp:ImageButton ID="ImageButton1" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/2mWDFVgDGz5NPQp62dvcP9.jpg"/>
                                                                                                            <asp:ImageButton ID="ImageButton2" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/Best-Android-Phones-Header.jpg"/>
                                                                                                            <asp:ImageButton ID="ImageButton3" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/best-phones-2021.jpg"/>
                                                                                                            <asp:ImageButton ID="ImageButton4" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/best battery life phone copy.jpg"/>
                                                                                                            <asp:ImageButton ID="ImageButton5" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/Best smartphone copy.jpg"/>
                                                                                                            <asp:ImageButton ID="ImageButton6" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" ImageUrl="~/Images/Phones/budget-android-phone-2048px-3x2-1.jpg"/>
                                    
                                    </td>

                                    </tr>

                                <tr>
                                                                     <td>
                                                                         <asp:ImageButton ID="ImageButton8" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/DqLwB7fD4xmVpkdfx7tHmh.jpg" Width="88px" />
                                                                         <asp:ImageButton ID="ImageButton9" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/IMG_BestFor_SmallPhones_iPhone13Mini_Large@2x.jpg" Width="88px" />
                                                                         <asp:ImageButton ID="ImageButton10" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/IMG_ImgName_Large@2x.jpg" Width="88px" />
                                                                         <asp:ImageButton ID="ImageButton11" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/mobile-phones-design-technology-roundups_hero.jpg" Width="88px" />
                                                                         <asp:ImageButton ID="ImageButton12" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/p0b6ky91.jpg" Width="88px" />
                                                                         <asp:ImageButton ID="ImageButton13" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" ImageUrl="~/Images/Phones/Palm-Phone-9-of-13.jpg" Width="88px" />
                                    
                                    </td>

                                    </tr>

                                </table>
            </div>


    </form>
</body>
</html>
