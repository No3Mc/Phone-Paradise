<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStaff.aspx.cs" Inherits="Staff_AddStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>

             <asp:Label ID="lblStaffName" runat="server" Text="Staff Name:" CssClass ="lblStaffName"></asp:Label><asp:TextBox ID="txtSName" runat="server"   CssClass ="txtSName" ToolTip="Enter Staff Name" ></asp:TextBox> </div>
                        <div><asp:Label ID="lblStaffEmail" runat="server" Text="Email Address:" CssClass ="lblStaffEmail"></asp:Label><asp:TextBox ID="txtSEmail" runat="server"  CssClass ="txtSEmail" ToolTip="Enter Email" ></asp:TextBox> </div>
                        <div><asp:Label ID="lblStaffPassword" runat="server" Text="Password:" CssClass ="lblStaffPassword"></asp:Label><asp:TextBox ID="txtSPassword" runat="server" CssClass ="txtSPassword"  ToolTip="Enter Password" ></asp:TextBox></div>
                        <div><asp:Label ID="lblStaffPosition" runat="server" Text="Position:" CssClass ="lblStaffPosition"></asp:Label><asp:TextBox ID="txtSPosition" runat="server" CssClass ="txtSPosition"  ToolTip="Enter Company Position"></asp:TextBox></div>
                        <div><asp:Label ID="lblStaffTelephoneNo" runat="server" Text="Telephone:" CssClass ="lblStaffTelephoneNo"></asp:Label><asp:TextBox ID="txtSTelephone" runat="server" CssClass ="txtSTelephone" ToolTip="Enter PhoneNo" ></asp:TextBox></div>

                        
                        
                        
                        

                        <div><asp:Button ID="btnCancel" runat="server" CssClass ="btnCancel"  OnClick="btnCancel_Click" Text="Cancel" ToolTip="Proceed back to Staff Main Page" />
                        <asp:Button ID="btnOK" runat="server"  CssClass ="btnOK" OnClick="btnOK_Click" Text="OK" ToolTip="Adds Stock to database" />

                        <asp:Label ID="lblError" runat="server" CssClass="lblError" Text="Error Label" ToolTip="Error" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
