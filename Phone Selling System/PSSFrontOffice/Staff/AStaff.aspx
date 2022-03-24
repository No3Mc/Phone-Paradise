<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="Staff_AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                         <div>

            <asp:Label ID="Label4" runat="server" Text="Staff No"></asp:Label>

            <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>

        </div>
             <div>

            <asp:Label ID="Label5" runat="server" Text="Staff Name"></asp:Label>

            <asp:TextBox ID="txtSName" runat="server"></asp:TextBox>

        </div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="txtSPassword" runat="server"></asp:TextBox>
        </div>

                <div>
                    <asp:Label ID="Label2" runat="server" Text="Position"></asp:Label>
                    <asp:TextBox ID="txtSPos" runat="server"></asp:TextBox>
        </div>

                <div>
                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtSEmail" runat="server"></asp:TextBox>
        </div>

                        <div>
                    <asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label>
                            <asp:TextBox ID="txtSPhone" runat="server"></asp:TextBox>
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
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />

        </p>
        </div>
    </form>
</body>
</html>
