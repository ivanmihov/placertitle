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

            // Retrieve username from cookies
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null)
                {
                    txtUsername.Text = Request.Cookies["UserName"].Value;
                }
            }
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            // Store username in the session
            Session["username"] = txtUsername.Text;
            
            // Store username in cookies for 30 days
            if (chkRememberLogin.Checked)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Cookies["UserName"].Value = txtUsername.Text.Trim();

            // Go to main menu
            Response.Redirect("~/MainMenu.aspx");
        }
    }
}