using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApplication
{
    public class SampleClass
    {
        private void InsertData()
        {
            int roll_no = 1110;
            string name = "SAt";
            string classText = "Intermediate";
            string sex = "Female";
            string email = "abc@aba.com";
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("insert into registration(roll_no,name,class,sex,email) values('" + roll_no.ToString() + "','" + name + "','" + classText + "','" + sex + "','" + email + "')", con);

            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Data inserted successfully");

                con.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }



        }  
    }
}
