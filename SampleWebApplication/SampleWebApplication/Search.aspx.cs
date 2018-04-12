using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApplication
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var searchTerm = string.IsNullOrWhiteSpace(Request.QueryString["Serchterm"].ToString()) ? "" : Request.QueryString["Serchterm"].ToString();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string script = "alert(\"" + searchTerm + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }

            Response.Redirect($"~/Account.aspx?Acc={searchTerm}");

        }
    }
}