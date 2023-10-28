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
    <title>Clean ASP.NET Theme</title>
    <link rel="stylesheet" type="text/css" href="~/DefStyles/DefaultStyleSheet.css" />
    <style type="text/css">
        body {
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
        }
        .filter-container {
            position: absolute;
            left: 0;
            top: 0;
            width: 200px;
            height: 100%;
            overflow-y: auto;
        }
        .main-content {
            margin-left: 210px;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 10px 0;
        }

        .filters {
            float: left;
            width: 250px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin-right: 20px;
        }


        .filter-label {
            font-weight: bold;
            margin-bottom: 10px;
        }


        .filter-dropdown {
            width: 100%;
            margin-bottom: 15px;
        }


        .logo img {
            max-width: 100%;
            height: auto;
        }
        .menu {
            list-style-type: none;
            margin: 0;
            padding: 0;
        }
        .menu li {
            display: inline-block;
            margin-right: 20px;
        }
        .menu a {
            text-decoration: none;
            color: #333;
            font-weight: bold;
        }
        .content {
            text-align: center;
            margin-top: 20px;
        }
        .product {
            margin: 10px;
            max-width: 200px;
            height: auto;
        }
        .menu-button {
            padding: 10px 20px;
            background-color: transparent;
            border: 2px solid #007bff;
            color: #007bff;
            text-decoration: none;
            font-size: 16px;
            font-weight: bold;
            cursor: pointer;
            transition: background-color 0.3s ease, color 0.3s ease;
        }
        .menu-button:hover {
            background-color: #007bff;
            color: #fff;
        }

    </style>
</head>
<body>



    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <div class="logo">
                    <img src="~/Images/Logo/Logo.jpg" alt="Company Logo" />
                </div>
                <ul class="menu">
                    <li>
                        <asp:Button ID="btnSales" runat="server" Text="Sales" CssClass="menu-button" /></li>
                    <li>
                        <asp:Button ID="btnLocation" runat="server" Text="Location" CssClass="menu-button" /></li>
                    <li>
                        <asp:Button ID="btnShopPhones" runat="server" Text="Shop Phones" CssClass="menu-button" /></li>
                    <li>
                        <asp:Button ID="btnSignin" runat="server" Text="Signin" CssClass="menu-button" /></li>
                    <li>
                        <asp:Button ID="btnAdmLogin" runat="server" Text="Adm Login" CssClass="menu-button" OnClick="Button10_Click" /></li>
                </ul>
            </div>
            <div class="content">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242696?$l-large$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10197974_002?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242698?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242714?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242716?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255005_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10232919_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248085_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10240843_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255005_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242753?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248085_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton20" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10244091_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton21" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10250273?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton23" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton25" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255035_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton27" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247663_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton31" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242754?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton35" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton37" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton38" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton39" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10197969_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton40" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton41" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10240843_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton42" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248086_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton44" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247939_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton45" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton46" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10247665?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton48" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248086_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton47" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton43" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10243709_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton36" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10251635?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton34" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton49" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254759_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton33" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton32" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242733?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton30" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10197969_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton29" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254759_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton28" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242701?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247675_black?$g-small$&fmt=auto" CssClass="product" />

                <asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton50" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254759_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton51" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton52" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242733?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton53" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10197969_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton54" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254759_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton57" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242701?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton58" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247675_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton61" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10244091_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton62" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10248091?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton63" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton64" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247663_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton66" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242752?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton67" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10235767?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton68" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10243060_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton69" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton70" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242697?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton71" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247675_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton72" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256438?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton75" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248492_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton76" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248086_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton79" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242739?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton80" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256445?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton78" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10248094?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton77" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251619_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton74" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10243709_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton73" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255005_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton65" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton60" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256465?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton59" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton56" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton55" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248463_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton81" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton82" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton83" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton84" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230564_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton85" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242699?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton86" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton87" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton88" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256486?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton89" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10201786?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton90" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242734?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton91" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton92" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248463_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton93" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton94" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254388_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton95" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251619_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton96" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242759?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton97" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250060_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton98" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton99" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242738?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton100" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10240843_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton101" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton102" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton103" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10197969_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton104" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242758?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton105" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242702?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton106" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton107" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton108" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250060_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton109" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton110" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton111" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247681_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton112" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10243060_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton113" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton114" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247663_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton115" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243722?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton116" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10241107?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton117" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton118" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247681_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton119" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256471?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton120" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10235780?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton121" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252930?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton122" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256456?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton123" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242715?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton124" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251632_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton125" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255005_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton126" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256221?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton127" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251619_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton128" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243229?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton129" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton130" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242719?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton131" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251617_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton132" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242720?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton133" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton134" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton135" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton136" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton137" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252921?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton138" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247530_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton139" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242707?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton140" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10236205?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton141" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242704?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton142" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252914?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton143" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10248105_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton144" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251617_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton145" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243238?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton146" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10248614?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton147" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_cream?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton148" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250423_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton149" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10241100?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton150" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton151" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256468?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton152" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252940?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton153" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242732?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton154" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256477?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton155" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10235781?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton156" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247530_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton157" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251249_blue_002?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton158" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252992?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton159" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10242696_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton160" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton161" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton162" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242703?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton163" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243247?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton164" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton165" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254388_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton166" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247939_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton167" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256492?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton168" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10243709_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton169" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230569_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton170" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton171" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton172" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton173" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton174" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251249_black_002?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton175" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton176" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256461?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton177" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10247940?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton178" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251632_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton179" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10251631?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton180" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252931?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton181" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton182" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton183" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250060_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton184" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10253007?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton185" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_cream?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton186" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254751_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton187" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton188" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton189" runat="server" ImageUrl="https://www.currys.co.uk/products/nothing-phone-1-8-256-gb-black-10246197.html" CssClass="product" />
                <asp:ImageButton ID="ImageButton190" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10254144?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton191" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton192" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10253198_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton193" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242757?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton194" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242708?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton195" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246895_cream?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton196" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250427_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton197" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243734?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton198" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton199" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10253198_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton200" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252987?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton201" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton202" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250427_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton203" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243231?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton204" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242721?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton205" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251694_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton206" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10247939?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton207" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton208" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252924?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton209" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton210" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton211" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256431?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton212" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256415?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton213" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242717?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton214" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250427_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton215" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256439?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton216" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246943_cream?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton217" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251240_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton218" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254751_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton219" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250500_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton220" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256459?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton221" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton222" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247939_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton223" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242725?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton224" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242735?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton225" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242705?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton226" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243727?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton227" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton228" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251249_silver-grey_002?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton229" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230564_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton230" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256450?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton231" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton232" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_blue?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton233" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242749?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton234" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10254987_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton235" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10235769?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton236" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton237" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10248234?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton238" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242709?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton239" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10241508_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton240" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10253198_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton241" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton242" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247530_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton243" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10255061_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton244" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_purple?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton245" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242770?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton246" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10250090?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton247" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10256884_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton248" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_red?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton249" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10237493?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton250" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10236203_white?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton251" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243748?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton252" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10237495?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton253" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243724?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton254" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230564_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton255" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256446?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton256" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251694_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton257" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10242714_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton258" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_pink?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton259" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243738?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton260" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10215597_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton261" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242744?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton262" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_cream?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton263" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10251240_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton264" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10243232?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton265" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242762?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton266" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247523_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton267" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton268" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242737?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton269" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250500_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton270" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252999?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton271" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10253001?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton272" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10247523_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton273" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256416?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton274" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10241508_silver-grey?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton275" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242726?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton276" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242728?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton277" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256409?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton278" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252937?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton279" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10230581_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton280" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10242714_yellow?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton281" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242722?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton282" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252917?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton283" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10237498?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton284" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10250423_black?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton285" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10254130?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton286" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10252901?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton287" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10236273?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton288" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10253225?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton289" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10256406?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton290" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242713?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton291" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10250517?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton292" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242710?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton293" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242723?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton294" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10242711?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton295" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/M10246998_green?$g-small$&fmt=auto" CssClass="product" />
                <asp:ImageButton ID="ImageButton296" runat="server" ImageUrl="https://media.currys.biz/i/currysprod/10236208?$g-small$&fmt=auto" CssClass="product" />
            </div>
        </div>

        <div class="filter-container">
            <div class="filters">
                <asp:DropDownList ID="ddlPrice" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="By Price" Value="" />
                    <asp:ListItem Text="Up to £39.99" Value="39.99" />
                    <asp:ListItem Text="£40 to £59.99" Value="59.99" />
                    <asp:ListItem Text="£60 to £99.99" Value="99.99" />
                    <asp:ListItem Text="£100 to £499" Value="499" />
                    <asp:ListItem Text="£500 to £999" Value="999" />
                    <asp:ListItem Text="£1000 and over" Value="1000" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlRating" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Customer Rating" Value="" />
                    <asp:ListItem Text="5 or more" Value="5" />
                    <asp:ListItem Text="4 or more" Value="4" />
                    <asp:ListItem Text="3 or more" Value="3" />
                    <asp:ListItem Text="2 or more" Value="2" />
                    <asp:ListItem Text="1 or more" Value="1" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlType" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Type" Value="" />
                    <asp:ListItem Text="Android smartphones" Value="Android smartphones" />
                    <asp:ListItem Text="Foldable and flip phones" Value="Foldable and flip phones" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlBrand" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Brand" Value="" />
                    <asp:ListItem Text="APPLE" Value="APPLE" />
                    <asp:ListItem Text="SAMSUNG" Value="SAMSUNG" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlOS" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Operating System" Value="" />
                    <asp:ListItem Text="Android" Value="Android" />
                    <asp:ListItem Text="Android Go" Value="Android Go" />
                    <asp:ListItem Text="iOS" Value="iOS" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlExpandableMemory" CssClass="filter-dropdown" runat="server" AutoPostBack="true">
                    <asp:ListItem Text="Expandable Memory" Value="" />
                    <asp:ListItem Text="No" Value="No" />
                    <asp:ListItem Text="Yes" Value="Yes" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlInternalMemory" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Internal Memory" Value="" />
                    <asp:ListItem Text="128 GB" Value="128" />
                    <asp:ListItem Text="256 GB" Value="256" />
                    <asp:ListItem Text="512 GB" Value="512" />
                    <asp:ListItem Text="64 GB" Value="64" />
                    <asp:ListItem Text="1 TB" Value="1000" />
                    <asp:ListItem Text="32 GB" Value="32" />
                    <asp:ListItem Text="8 GB or less" Value="8" />
                    <asp:ListItem Text="16 GB" Value="16" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlScreenSize" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Screen Size" Value="" />
                    <asp:ListItem Text="6' to 6.9'" Value="6.9" />
                    <asp:ListItem Text="5' and under" Value="5" />
                    <asp:ListItem Text="5' to 5.9'" Value="5.9" />
                    <asp:ListItem Text="Flip phones" Value="Flip phones" />
                    <asp:ListItem Text="Foldable phones" Value="Foldable phones" />
                    <asp:ListItem Text="6' or more" Value="6" />
                    <asp:ListItem Text="7' and over" Value="7" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlColor" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Color" Value="" />
                    <asp:ListItem Text="Black" Value="Black" />
                    <asp:ListItem Text="Blue" Value="Blue" />
                    <asp:ListItem Text="Cream" Value="Cream" />
                    <asp:ListItem Text="Gold" Value="Gold" />
                    <asp:ListItem Text="Green" Value="Green" />
                    <asp:ListItem Text="Pink" Value="Pink" />
                    <asp:ListItem Text="Purple" Value="Purple" />
                    <asp:ListItem Text="Red" Value="Red" />
                    <asp:ListItem Text="Silver/Grey" Value="Silver/Grey" />
                    <asp:ListItem Text="White" Value="White" />
                </asp:DropDownList>

                <asp:DropDownList ID="ddlOurExpertsLove" runat="server" CssClass="filter-dropdown" AutoPostBack="true">
                    <asp:ListItem Text="Our Experts Love" Value="" />
                    <asp:ListItem Text="Dual SIM" Value="Dual SIM" />
                    <asp:ListItem Text="eSIM enabled" Value="eSIM enabled" />
                    <asp:ListItem Text="Single SIM" Value="Single SIM" />
                    <asp:ListItem Text="Yes" Value="Yes" />
                </asp:DropDownList>
            </div>
        </div>






    </form>
</body>
</html>

