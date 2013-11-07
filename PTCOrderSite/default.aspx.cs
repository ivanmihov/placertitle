using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTCOrderSite
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This is an example of how you would change the attributes
            // of a page element when the page loads.
            txtTest.BorderStyle = BorderStyle.None;
        }

        protected void btnShowHide_Click(object sender, EventArgs e)
        {
            // When the button is clicked toggle whether or not
            // the sample text is displayed
            txtTest.Visible = !txtTest.Visible;
        }

        protected void btnChangeColor_Click(object sender, EventArgs e)
        {
            // When the button is clicked change the color
            txtTest.ForeColor = Color.Red;
        }
    }
}