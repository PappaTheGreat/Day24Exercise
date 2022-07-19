using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Day24ExerciseProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=HR; Integrated Security=true"))
            {

                string email, password;
                email = txtEmail.Text;
                password = txtPass.Text;
                cmd = new SqlCommand("select * from registration where Email_Id = '" + email + "' and password = '" + password + "'  ", conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lblMessage.Text = "Login Successful";
                }
                else
                {
                    lblMessage.Text = "Invalid Credentials Entered!!!";
                }

                Server.Transfer("HomePage.aspx", true);

            }

          
        }
    }
}