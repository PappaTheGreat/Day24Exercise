using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day24ExerciseProject
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FirstName"] != null)
            {
                lblWelcomeMessage.Text = $"Welcome, {Session["FirstName"]}";
            }
            else
            {
                lblWelcomeMessage.Text = "Welcome, Guest";
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["FirstName"] != null)
            {
                Response.Cookies["FirstName"].Expires = DateTime.Now.AddDays(-1);            }
        }
    }
}