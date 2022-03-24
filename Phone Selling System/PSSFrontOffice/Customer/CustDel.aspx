<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustDel.aspx.cs" Inherits="Customer_CustDel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are your sure?<br />
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnNo_Click" />

        </div>
    </form>
</body>
</html>
