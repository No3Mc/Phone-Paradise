<%--Written by Syed, Ethan, Talha, Luke, and Aqeel || P2652259|| Syed/No3Mc(https://github.com/No3Mc),  P2596393 || Ethan/Frizzle15(https://github.com/Frizzle15), 
    P2629099 || Talha(https://github.com/Talhamemon25), P2606530 || Luke/LLydiatt(https://github.com/LLydiatt)and Aqeel(https://github.com/AqeelAhmed12))

Stock Management by Syed Naqvi
Staff Management by Luke Lydiatt
Phones Management by Ethan Frizzell
Customer Management by Mahammad Talha
Supplier management by Aqeel Ahmed	


Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store--%>



<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Panel</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        #header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #333;
            padding: 10px 20px;
        }

        #logo {
            width: 195px;
        }

        #navigation {
            display: flex;
            gap: 10px;
        }

        .button {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            text-align: center;
        }

        .button:hover {
            background-color: #0056b3;
        }

        .content {
            text-align: center;
            padding: 20px;
        }

        .button-container {
            display: flex;
            justify-content: center;
            gap: 20px;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <img id="logo" src="~/Images/Logo/Logo.jpg" alt="Logo" />
            <div id="navigation">
                <asp:Button ID="Button2" runat="server" CssClass="button" Text="Edit Sales" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" CssClass="button" Text="Edit Location" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" CssClass="button" Text="Edit Phones" OnClick="Button4_Click" />
            </div>
        </div>
        <div class="content">
            <asp:Button ID="Button5" runat="server" CssClass="button" Text="Management Panel" />
            <div class="button-container">
                <asp:Button ID="Button6" runat="server" CssClass="button" Text="Stock Management" OnClick="Button6_Click" />
                <asp:Button ID="Button7" runat="server" CssClass="button" Text="Phone Management" OnClick="Button7_Click" />
                <asp:Button ID="Button8" runat="server" CssClass="button" Text="Staff Management" OnClick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" CssClass="button" Text="Customer Management" OnClick="Button9_Click" />
                <asp:Button ID="Button10" runat="server" CssClass="button" Text="Supplier Management" OnClick="Button10_Click" />
            </div>
        </div>
    </form>
</body>
</html>



