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
    <title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            width: 350px;
            background-color: #fff;
            border: 1px solid #ccc;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 5px;
            padding: 170px;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }
        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
            transition: border-color 0.3s;
        }
        .form-group input[type="text"]:focus,
        .form-group input[type="password"]:focus {
            border-color: #007bff;
        }
        .btn-login {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 3px;
            cursor: pointer;
            transition: background-color 0.3s;
        }
        .btn-login:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <label for="user">Username</label>
                <asp:TextBox ID="user" runat="server" BorderColor="Blue" ToolTip="Please enter the username" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="pass">Password</label>
                <asp:TextBox ID="pass" runat="server" TextMode="Password" ToolTip="Enter your password" BorderColor="Blue" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Login" ToolTip="Log in to your account" CssClass="btn-login" OnClick="Button1_Click" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Cancel</asp:HyperLink>
        </div>
    </form>
</body>
</html>



