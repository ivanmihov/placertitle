using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTCOrderSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Put cursor in username prompt
            txtUsername.Focus();
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            // Store username in the session
            Session["username"] = txtUsername.Text;

            // Go to main menu
            Response.Redirect("~/MainMenu.aspx");
        }
    }
}