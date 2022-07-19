using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Day24ExerciseProject
{
    public partial class Registration_Page : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Resetbtn()
        {
           txtConfirmPassword.Text = "";
            txtEmailId.Text = "";
            txtFirstName.Text = "";
            txtPassword.Text = "";   
            txtFirstName.Focus();
        }

        protected void btnReset_Click1(object sender, EventArgs e)
        {
            this.Resetbtn();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=HR; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("usp_registrationaspnetproc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserEmailId", txtEmailId.Text);
                    cmd.Parameters.AddWithValue("@UserFirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@UserPass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@UserConPass", txtConfirmPassword.Text);
                    cmd.Parameters.AddWithValue("@UserGender", txtGender.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            Response.Cookies.Add(new HttpCookie("FirstName", txtFirstName.Text));
            Response.Cookies["FirstName"].Expires = DateTime.Now.AddDays(2);
            Server.Transfer("LoginPage.aspx", true);
        }
    }
}