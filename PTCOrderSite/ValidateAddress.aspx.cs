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
            // Add a row to the results table
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            cell.Text = String.Format("{0}\n{1}, {2} {3}",
                Request["txtAddress"], Request["txtCity"], Request["txtState"], Request["txtZip"]);
            row.Cells.Add(cell);
            tblSearchResults.Rows.Add(row);
        }

        protected void cmdContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }
    }
}