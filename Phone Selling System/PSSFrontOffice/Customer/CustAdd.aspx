<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustAdd.aspx.cs" Inherits="Customer_CustAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnYes" runat="server" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />

        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>

        <div>

            <asp:TextBox ID="txtCustID" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>


<%--            //[txtCustID]
            //[txtAddress]
            //[txtDOB]     
            //[txtName]  
            //[txtEmail] 
            //[txtPhoneNo]--%>

        </div>
    </form>
</body>
</html>
