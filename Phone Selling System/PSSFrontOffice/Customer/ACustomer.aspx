<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        
        <div>

            <asp:Label ID="Label5" runat="server" Text="CustID"></asp:Label>

            <asp:TextBox ID="txtCustID" runat="server"></asp:TextBox>

        </div>

                <div>
                    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </div>

                <div>
                    <asp:Label ID="Label1" runat="server" Text="DOB"></asp:Label>
                    <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </div>

                <div>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>

                <div>
                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>

                        <div>
                    <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>
                            <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        </div>


        <div>

        </div>

                <div>
                    <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>

        </div>

                <div>

        </div>


        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" Text="Cancel" OnClick="btnFind_Click" />

        </p>


    </form>
</body>
</html>
