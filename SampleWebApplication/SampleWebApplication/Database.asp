<%@ Page Language="C#"%>
<script runat="server">
void SubmitBtn _Click(object sender, EventArgs e) { 
SqlDataReader reader = cmd.ExecuteReader();
Response.Write(reader.GetString(1));
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