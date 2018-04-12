<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SampleWebApplication.Index"  ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form runat="server" id="form1">
    <div>
        
        <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
        <br /><br /><br /><br />

    Customer Id: <asp:TextBox ID="txtCustomerId" runat="server" />
        <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Submit" />
        <hr /><br /><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="Customer Id" />
                <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
            </Columns>
         </asp:GridView><br /><br />
        Search String: <asp:TextBox ID="TextBox1" runat="server" />
        <asp:Button ID="search" Text="Search" runat="server" OnClick="search_Click"/>
        <hr /><br /><br /><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br /><br /><br /><br />
    </div>
   </form>
</body>
</html>
