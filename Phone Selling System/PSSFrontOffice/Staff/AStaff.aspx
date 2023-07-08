<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="Staff_AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <style>
            body {
                background-image: url(http://localhost:56842/Staff/Background/Background.jpg);
            }
        </style>
        <div>
            <asp:ListBox ID="lstStaff" runat="server" Height="171px" Width="185px"></asp:ListBox>
        </div>
        <div>
            <asp:ListBox ID="lstStaff2" runat="server" Height="171px" OnSelectedIndexChanged="lstStaff_SelectedIndexChanged" Width="185px"></asp:ListBox>
            <asp:Label ID="Label4" runat="server" Text="Staff No" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Staff Name" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtSName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Password" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtSPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Position" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtSPos" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Email" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtSEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Phone" ForeColor="#0066FF"></asp:Label>
            <asp:TextBox ID="txtSPhone" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <asp:Button ID="btnOK1" runat="server" Text="OK" />
            <asp:Button ID="btnOK2" runat="server" Text="OK" />
        </p>
        <p>
            <asp:Button ID="btnOK3" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" ToolTip="Using StaffNo to locate user" />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>

    </form>
</body>
</html>
