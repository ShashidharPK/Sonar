<%@ Page Language="C#"%>
<script runat="server">
namespace ExternalExecution
{
class CallExternal
{
static void Main(string[] args)
{
String arg1=args[0];
System.Diagnostics.Process.Start("doStuff.exe", arg1);
}
}
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