using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTCOrderSite
{
    public partial class PTCOrderSiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object username = Session["username"];
            if ((username == null || username.ToString() == "")
                && Page.ToString() != "ASP.login_aspx")
                Response.Redirect("~/Login.aspx");
        }
    }
}