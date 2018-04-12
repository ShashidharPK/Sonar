using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace SampleWebApplication
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"].ToString();

                    if (id == null)
                    {
                        lblId.Text = "NA";
                    }
                    else
                    {
                        lblId.Text = id;
                    }
                }
                else {
                    if (Session["user"] == null)
                    {
                        Response.Redirect("~/Login.aspx");
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Submit(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE CustomerId = '" + txtCustomerId.Text + "'"))
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("CustomerId");
                    dt.Columns.Add("ContactName");
                    dt.Rows.Add(new object[] { txtCustomerId.Text, "Prateek" });
                    ds.Tables.Add(dt);

                    GridView1.DataSource = ds.Tables[0].DefaultView;
                    GridView1.DataBind();
                    //con.Open();
                    //cmd.Connection = con;
                    //GridView1.DataSource = cmd.ExecuteReader();
                    //GridView1.DataBind();
                    //con.Close();
                }
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string input="";
            try
            {
                cmdExecution("MyArgs");
                input = TextBox1.Text;
                Label2.Text = input;
                ReadFile(input);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Response.Redirect($"~/Search.aspx?Serchterm={input}");
            }
        }

        public void cmdExecution(String ident)
         {
             try
             {

                   ProcessStartInfo proStartInfo = new ProcessStartInfo("KidnappedProgram.exe");
                   proStartInfo.UseShellExecute = true;
                   proStartInfo.Arguments = ident;
                   Process.Start(proStartInfo);

             }
             catch (Exception)
             {
             }
         }

        public string ReadFile(string Path)
        {
            string content = string.Empty;
            try
            {
            using (StreamReader sr = new StreamReader(Path))
            {
                content = sr.ReadToEnd();
            }
            
            }
            catch (Exception)
            {
            }
            return content;
        }
    }
}