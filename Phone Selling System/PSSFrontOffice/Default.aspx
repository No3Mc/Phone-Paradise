<%--Written by Syed, Ethan, Talha, Luke, and Aqeel || P2652259|| Syed/No3Mc(https://github.com/No3Mc),  P2596393 || Ethan/Frizzle15(https://github.com/Frizzle15), 
    P2629099 || Talha(https://github.com/Talhamemon25), P2606530 || Luke/LLydiatt(https://github.com/LLydiatt)and Aqeel(https://github.com/AqeelAhmed12))

Stock Management by Syed Naqvi
Staff Management by Luke Lydiatt
Phones Management by Ethan Frizzell
Customer Management by Mahammad Talha
Supplier management by Aqeel Ahmed	


Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>



<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <link  rel="stylesheet" type="text/css" href="~/Styles/DefaultStyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            width: 195px;
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
                            <td class="auto-style1">
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
                                <td class="auto-style1"></td>
                            </tr>
                            <td class="auto-style1"></td>
                            <td class="auto-style6"></td>
                            <td class="auto-style5"></td>
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
