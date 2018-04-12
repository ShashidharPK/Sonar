<%@ Page Language="C#"%>
<script runat="server">
    void SubmitBtn_Click(object sender, EventArgs e) {
        Response.Redirect("~/folder/Login.aspx");
    }
</script>
<html>
<body>
<form id="form1" runat="server">
<asp:TextBox ID="InputText" Runat="server" TextMode="MultiLine" Width="300px" Height="150px"> 
</asp:TextBox>
<asp:Button ID="SubmitBtn" Runat="server" Text="Submit" OnClick="SubmitBtn _Click"/> 
</form>
</body>
</html>