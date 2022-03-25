<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindSupplier.aspx.cs" Inherits="Supplier_FindSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1426px;
        }
        .auto-style2 {
            margin-left: 27px;
        }
        .auto-style3 {
            margin-left: 43px;
        }
        .auto-style4 {
            margin-left: 25px;
        }
        .auto-style5 {
            margin-left: 26px;
        }
        .auto-style6 {
            margin-left: 33px;
        }
        .auto-style7 {
            margin-left: 2px;
        }
    </style>
</head>
<body style="width: 848px; height: 473px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="#660033" ForeColor="Lime" Text="Find Supplier"></asp:Label>
        </div>
        <p class="auto-style1">
            <asp:Label ID="Label2" runat="server" ForeColor="Blue" Text="SupplierID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SID" runat="server" CssClass="auto-style4" ForeColor="#996633" Width="129px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" ForeColor="Blue" Text="SupplierName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SName" runat="server" CssClass="auto-style2" ForeColor="#FF9933" Width="130px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Label ID="Label4" runat="server" ForeColor="Blue" Text="SupplierAddress"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SAddress" runat="server" CssClass="auto-style4" ForeColor="#CC66FF" Width="132px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Label ID="Label5" runat="server" ForeColor="Blue" Text="SupplierMobileNo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SMobileNo" runat="server" CssClass="auto-style5" ForeColor="#339933" Width="129px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Label ID="Label6" runat="server" ForeColor="Blue" Text="SupplierEmail"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SEmail" runat="server" CssClass="auto-style2" ForeColor="#990099" Width="130px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Label ID="Label7" runat="server" ForeColor="Blue" Text="SupplierDOB"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SDOB" runat="server" CssClass="auto-style6" ForeColor="#336699" Width="131px"></asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#99FF66" ForeColor="Red" Height="36px" OnClick="Button1_Click" Text="OK" Width="101px" />
            <asp:Button ID="Button2" runat="server" BackColor="#99FF66" CssClass="auto-style3" ForeColor="Red" Height="36px" OnClick="Button2_Click" Text="Cancel" Width="101px" />
            <asp:Button ID="SMain" runat="server" BackColor="#99FF66" CssClass="auto-style3" ForeColor="Red" Height="36px" OnClick="Button2_Click" Text="Suplier main" Width="101px" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" BackColor="#669900" CssClass="auto-style7" ForeColor="Yellow" Height="36px" OnClick="btnFind_Click" Text="Find" Width="49px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
