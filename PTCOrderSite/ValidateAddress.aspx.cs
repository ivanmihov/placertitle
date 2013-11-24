using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

using PTCOrderSite.modules;

namespace PTCOrderSite
{
    public partial class ValidateAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Use DataQuickResponse object
            DataQuickResponse dqResponse = new DataQuickResponse(
                Request.Form["ctl00$body$txtAddress"], Request.Form["ctl00$body$txtZip"]);

            while (dqResponse.Read())
            {
                // Add list item to results selection
                ListItem rdbtnSelection = new ListItem();
                rdbtnSelection.Text = rdbtnSelection.Value = String.Format("{0}, {1}, {2} {3}<br />{4} County<br />"
                    + "APN: {5}<br />Owner 1: {6} {7}<br />Owner 2: {8} {9}",
                    dqResponse.Address, dqResponse.City, dqResponse.State, dqResponse.Zip, dqResponse.County,
                    dqResponse.APN, dqResponse.Owner1First, dqResponse.Owner1Last, dqResponse.Owner2First, dqResponse.Owner2Last);
                rdbtnSelection.Selected = true; // Default the first one to be selected
                rdbtnlstAddresses.Items.Add(rdbtnSelection);
            }
        }
    }
}