using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;

namespace SampleWebApplication
{
    public class Database_aspx
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var query = "";
            SqlConnection connection = new SqlConnection("");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            var response = reader.GetString(1);
        }
    }
}