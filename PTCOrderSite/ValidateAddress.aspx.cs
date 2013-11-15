using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTCOrderSite
{
    public partial class ValidateAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add list item to results selection
            ListItem rdbtnSelection = new ListItem();
            rdbtnSelection.Text = rdbtnSelection.Value = String.Format("{0}, {1}, {2} {3}",
                Request.Form["ctl00$body$txtAddress"], Request.Form["ctl00$body$txtCity"],
                Request.Form["ctl00$body$txtState"], Request.Form["ctl00$body$txtZip"]);
            rdbtnSelection.Selected = true; // Default the first one to be selected
            rdbtnlstAddresses.Items.Add(rdbtnSelection);

            // Add some additional items for demonstration
            rdbtnSelection = new ListItem("Second Result");
            rdbtnlstAddresses.Items.Add(rdbtnSelection);
            rdbtnSelection = new ListItem("Third Result");
            rdbtnlstAddresses.Items.Add(rdbtnSelection);

            // Add an other item keep as entered
            rdbtnSelection = new ListItem("Other");
            rdbtnlstAddresses.Items.Add(rdbtnSelection);
        }
    }
}