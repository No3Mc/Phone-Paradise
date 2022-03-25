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
         <link  rel="stylesheet" type="text/css" href="~/DefStyles/DefaultStyleSheet.css" />
    <style type="text/css">

                    body {
  background-image: url('/Images/Backgrounds/Stock/1.jpg');
}
        .auto-style8 {
            position: absolute;
            left: 964px;
            top: 129px;
            height: 33px;
        }
        .auto-style9 {
            position: absolute;
            left: 1099px;
            top: 133px;
        }
        .auto-style10 {
            position: absolute;
            left: 182px;
            top: 118px;
            width: 135px;
            height: 78px;
        }
        .auto-style11 {
            position: absolute;
            left: 718px;
            top: 131px;
        }
        .auto-style12 {
            position: absolute;
            left: 534px;
            top: 132px;
            right: 1153px;
        }
        .auto-style13 {
            position: absolute;
            left: 401px;
            top: 128px;
            right: 1354px;
            width: 63px;
            height: 36px;
        }
        .auto-style14 {
            position: absolute;
            left: 955px;
            top: 221px;
        }
        .auto-style15 {
            position: absolute;
            left: 816px;
            top: 217px;
        }
        .auto-style16 {
            position: absolute;
            left: 668px;
            top: 213px;
        }
        .auto-style17 {
            position: absolute;
            left: 523px;
            top: 219px;
        }
        .auto-style18 {
            position: absolute;
            left: 395px;
            top: 217px;
        }
        .auto-style19 {
            position: absolute;
            left: 1114px;
            top: 221px;
        }
        .auto-style20 {
            position: absolute;
            left: 394px;
            top: 429px;
        }
        .auto-style21 {
            position: absolute;
            left: 526px;
            top: 429px;
        }
        .auto-style22 {
            position: absolute;
            left: 676px;
            top: 433px;
        }
        .auto-style23 {
            position: absolute;
            left: 819px;
            top: 436px;
        }
        .auto-style24 {
            position: absolute;
            left: 955px;
            top: 432px;
        }
        .auto-style25 {
            position: absolute;
            left: 1112px;
            top: 439px;
        }
        .auto-style26 {
            position: absolute;
            left: 185px;
            top: 231px;
        }
    </style>

    </head>
<body>
    <form id="form1" runat="server">



    <%--Taken from :https://www.renaultgroup.com/--%>
    <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/Images/Logo/Logo.jpg" CssClass = "auto-style10" />
    <asp:Button ID="btnSales" runat="server" Text="Sales" CssClass = "auto-style13"/>
    <asp:Button ID="btnLocation" runat="server" Text="Location" Width="131px" CssClass = "auto-style12"/>
    <asp:Button ID="btnShopPhones" runat="server" Text="Shop Phones" CssClass = "auto-style11"/>
    <asp:Button ID="btnSignin" runat="server" Text="Signin" CssClass = "auto-style8" />
    <asp:Button ID="btnAdmLogin" runat="server" Text="Adm Login" CssClass = "auto-style9" OnClick="Button10_Click" />
    <asp:ImageButton ID="ImageButton1" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style20" ImageUrl="~/Images/Phones/2mWDFVgDGz5NPQp62dvcP9.jpg"/>
    <asp:ImageButton ID="ImageButton2" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style19" ImageUrl="~/Images/Phones/Best-Android-Phones-Header.jpg"/>
    <asp:ImageButton ID="ImageButton3" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style23" ImageUrl="~/Images/Phones/best-phones-2021.jpg"/>
    <asp:ImageButton ID="ImageButton4" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style16" ImageUrl="~/Images/Phones/best battery life phone copy.jpg"/>
    <asp:ImageButton ID="ImageButton5" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style14" ImageUrl="~/Images/Phones/Best smartphone copy.jpg"/>
    <asp:ImageButton ID="ImageButton6" runat="server" Height="173px" Width="88px" BorderColor="Black" BorderStyle="Solid" CssClass = "auto-style22" ImageUrl="~/Images/Phones/budget-android-phone-2048px-3x2-1.jpg"/>
    <asp:ImageButton ID="ImageButton8" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style21" ImageUrl="~/Images/Phones/DqLwB7fD4xmVpkdfx7tHmh.jpg" Width="88px" />
    <asp:ImageButton ID="ImageButton9" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style17" ImageUrl="~/Images/Phones/IMG_BestFor_SmallPhones_iPhone13Mini_Large@2x.jpg" Width="88px" />
    <asp:ImageButton ID="ImageButton10" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style18" ImageUrl="~/Images/Phones/IMG_ImgName_Large@2x.jpg" Width="88px" />
    <asp:ImageButton ID="ImageButton11" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style24" ImageUrl="~/Images/Phones/mobile-phones-design-technology-roundups_hero.jpg" Width="88px" />
    <asp:ImageButton ID="ImageButton12" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style15" ImageUrl="~/Images/Phones/p0b6ky91.jpg" Width="88px" ImageAlign="Bottom" />
    <asp:ImageButton ID="ImageButton13" runat="server" BorderColor="Black" BorderStyle="Solid" Height="173px" CssClass = "auto-style25" ImageUrl="~/Images/Phones/Palm-Phone-9-of-13.jpg" Width="88px" />
                                    
 


                                    
 

    <asp:Button ID="btnSelection" runat="server" Height="388px" Text="Selection" Width="136px"  CssClass = "auto-style26" />
                                    
 

    </form>
</body>
</html>
