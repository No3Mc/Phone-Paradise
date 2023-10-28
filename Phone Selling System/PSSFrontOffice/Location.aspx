<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Location.aspx.cs" Inherits="Location" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Smartlink Store Locations</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 5px;
        }

        h1 {
            color: #333;
        }

        .location {
            margin-bottom: 20px;
            padding: 10px;
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        .location h2 {
            margin: 0;
            color: #333;
        }

        .location p {
            margin-top: 5px;
            color: #666;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Our Store Locations</h1>
            
            <div class="location">
                <h2>London Store</h2>
                <p>Address: 123 Oxford Street, London, W1D 1AA</p>
                <p>Phone: +44 20 1234 5678</p>
                <p>Email: london@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Manchester Store</h2>
                <p>Address: 456 Market Street, Manchester, M1 2AB</p>
                <p>Phone: +44 161 9876 5432</p>
                <p>Email: manchester@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Birmingham Store</h2>
                <p>Address: 789 High Street, Birmingham, B3 3CD</p>
                <p>Phone: +44 121 6543 2109</p>
                <p>Email: birmingham@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Glasgow Store</h2>
                <p>Address: 101 Buchanan Street, Glasgow, G1 3HL</p>
                <p>Phone: +44 141 1234 5678</p>
                <p>Email: glasgow@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Edinburgh Store</h2>
                <p>Address: 456 Princes Street, Edinburgh, EH2 4AT</p>
                <p>Phone: +44 131 8765 4321</p>
                <p>Email: edinburgh@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Liverpool Store</h2>
                <p>Address: 789 Waterfront Road, Liverpool, L3 5XY</p>
                <p>Phone: +44 151 5678 9012</p>
                <p>Email: liverpool@smartlink.com</p>
            </div>

            <div class="location">
                <h2>Leeds Store</h2>
                <p>Address: 321 Park Avenue, Leeds, LS1 8HG</p>
                <p>Phone: +44 113 2345 6789</p>
                <p>Email: leeds@smartlink.com</p>
            </div>


        </div>
    </form>
</body>
</html>
