using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace SampleWebApplication
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var accNo = string.IsNullOrWhiteSpace(Request.QueryString["Acc"].ToString()) ? "" : Request.QueryString["Acc"].ToString();

            String query = "SELECT * FROM accts WHERE account = @accNo";

            using (SqlConnection connection = new SqlConnection(""))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var accNoParam = new SqlParameter("accNo", SqlDbType.Int);
                accNoParam.Value = accNo;

                command.Parameters.Add(accNo);
                var results = command.ExecuteReader();
            }
        }

        private static string GetLDAPInjection(string siteName, string filename, string managername,HttpRequest Request,HttpResponse Response)
        {
            //this is a string representing where the xml file is located
            string xmlFileName = "books.xml";
            var managerName = managername;
            // create an XPathDocument object
            XPathDocument XmlDoc = new XPathDocument(xmlFileName);
            XPathNavigator nav = XmlDoc.CreateNavigator();
            XPathExpression expr = nav.Compile("string(//user[name/text()='" + Request.QueryString["Username"] + "' and password/text()='" + Request.QueryString["Password"] + "']/account/text())");
            var returnUrl = "~/Login.aspx";
            String account = Convert.ToString(nav.Evaluate(expr));
            if (account == "")
            {
                // name+password pair is not found in the XML document

                // login failed.
            }
            else
            {
                Response.Redirect(returnUrl);
                // account found -> Login succeeded.
                // Proceed into the application.
            }
            DirectoryEntry de = new DirectoryEntry();
            DirectorySearcher src = new DirectorySearcher("(manager=" + managerName + ")");
            src.SearchRoot = de;
            src.SearchScope = SearchScope.Subtree;

            foreach (SearchResult res in src.FindAll())
            {

            }
            return "";
        }
    }
}