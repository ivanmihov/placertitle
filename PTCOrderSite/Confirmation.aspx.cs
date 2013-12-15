using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PTCOrderSite.modules;

namespace PTCOrderSite
{
    public partial class confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create new XmlWriter to output new order information
            MLHC_XmlWriter mlhcWriter = new MLHC_XmlWriter(String.Format("{0}\\{1}\\{2}",
                Request.PhysicalApplicationPath, ConfigurationManager.AppSettings["xmlOutputDirectory"],
                ConfigurationManager.AppSettings["xmlOutputFile"]));

            mlhcWriter.WriteElement("CUST_NUMBER", "");
            mlhcWriter.WriteElement("ORDER_SERVICE", "");
            mlhcWriter.WriteElement("ORDER_TYPE", "");

            mlhcWriter.CreateSection("GENERAL_INFO");
            mlhcWriter.WriteElement("REF_NUMBER", "");
            mlhcWriter.WriteElement("DUE_DATE", "");
            mlhcWriter.WriteElement("CONTACT_ENTERING", "");
            mlhcWriter.WriteElement("YOU_ARE", "");
            mlhcWriter.WriteElement("TRANSACTION_TYPE", "");
            mlhcWriter.WriteElement("PRODUCT", "");
            mlhcWriter.WriteElement("ENDORSEMENTS", "");
            mlhcWriter.CloseSection(); // GENERAL_INFO

            mlhcWriter.CreateSection("ESCROW_INFO");
            mlhcWriter.WriteElement("OFFICE", "");
            mlhcWriter.WriteElement("ESCROW_OFFICER", "");
            mlhcWriter.WriteElement("EST_CLOSING_DATE", "");
            mlhcWriter.WriteElement("POLICY_TYPE", "");
            mlhcWriter.CloseSection(); // ESCROW_INFO

            mlhcWriter.Close();
        }

        protected void lnkLogOut_Click(object sender, EventArgs e)
        {
            // Remove username from session
            Session["username"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}