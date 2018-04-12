<%@ Page Language="C#"%>
<script runat="server">
public ActionResult LogOn(LogOnModel model, string returnUrl)
{
    if (ModelState.IsValid)
    {
        if (MembershipService.ValidateUser(model.UserName, model.Password))
        {
            FormsService.SignIn(model.UserName, model.RememberMe);
            if (!String.IsNullOrEmpty(returnUrl))
            {	
				Response.Redirect(returnUrl);
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        else
        {	
			Redirect(returnUrl);
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
        }
    }
 
    // If we got this far, something failed, redisplay form
    return View(model);
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