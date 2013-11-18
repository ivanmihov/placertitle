using PTCOrderSite.modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTCOrderSite
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Load transaction types
            foreach (XmlTools.XmlResult result in XmlTools.ReadXmlList(
                Request.PhysicalApplicationPath + "inputSamples\\TransactionTypes.xml", "TRANSACTION_TYPES"))
            {
                ListItem item = new ListItem(result.Description, result.Code);
                transactionType.Items.Add(item);
            }
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}