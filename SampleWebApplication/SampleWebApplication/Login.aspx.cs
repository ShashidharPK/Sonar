using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName == "pks" && Login1.Password == "abcde")
            {
                Session["user"] = Login1.UserName.ToString();
                Response.Redirect($"~/Index.aspx?SessionId={Login1.UserName.ToString()}");
            }
        }

    }
}