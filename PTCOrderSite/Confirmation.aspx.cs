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

            mlhcWriter.CreateSection("ESCROW_TERMS");
            mlhcWriter.WriteElement("PURCHASE_PRICE", "");
            mlhcWriter.WriteElement("EARNEST_MONEY", "");
            mlhcWriter.WriteElement("LISTING_PERCENT", "");
            mlhcWriter.WriteElement("LISTING_AND_OR", "");
            mlhcWriter.WriteElement("SELLING_PERCENT", "");
            mlhcWriter.WriteElement("SELLING_AND_OR", "");
            mlhcWriter.CreateSection("WHO_PAYS");
            mlhcWriter.WriteElement("TITLE", "");
            mlhcWriter.WriteElement("ESCROW", "");
            mlhcWriter.WriteElement("TRANSFER_TAX", "");
            mlhcWriter.WriteElement("HOME_ASSOC", "");
            mlhcWriter.WriteElement("HOME_ASSOC_NAME", "");
            mlhcWriter.WriteElement("TRANSFER_FEE", "");
            mlhcWriter.WriteElement("TERMITE_REPORT", "");
            mlhcWriter.WriteElement("TERMITE_WORK", "");
            mlhcWriter.WriteElement("ROOF_REPORT", "");
            mlhcWriter.WriteElement("HOME_WARRANTY", "");
            mlhcWriter.WriteElement("HAZARD", "");
            mlhcWriter.WriteElement("PTC_TO_ORDER", "");
            mlhcWriter.CloseSection(); // WHO_PAYS
            mlhcWriter.CloseSection(); // ESCROW_TERMS

            mlhcWriter.CreateSection("PAYOFF_INFO");
            mlhcWriter.WriteElement("FIRST_LENDER_NAME", "");
            mlhcWriter.WriteElement("FIRST_LOAN_NUMBER", "");
            mlhcWriter.WriteElement("FIRST_PHONE", "");
            mlhcWriter.WriteElement("FIRST_DISPOSITION", "");
            mlhcWriter.WriteElement("SECOND_LENDER_NAME", "");
            mlhcWriter.WriteElement("SECOND_LOAN_NUMBER", "");
            mlhcWriter.WriteElement("SECOND_PHONE", "");
            mlhcWriter.WriteElement("SECOND_DISPOSITION", "");
            mlhcWriter.WriteElement("PAYOFF_SPECIAL_INSTR", "");
            mlhcWriter.CloseSection(); // PAYOFF_INFO

            mlhcWriter.CreateSection("SELLER_INFO");
            mlhcWriter.WriteElement("SELLER1_FIRST_NAME", "");
            mlhcWriter.WriteElement("SELLER1_MI", "");
            mlhcWriter.WriteElement("SELLER1_LAST_NAME", "");
            mlhcWriter.WriteElement("SELLER1_SSN", "");
            mlhcWriter.WriteElement("SELLER2_FIRST_NAME", "");
            mlhcWriter.WriteElement("SELLER2_MI", "");
            mlhcWriter.WriteElement("SELLER2_LAST_NAME", "");
            mlhcWriter.WriteElement("SELLER2_SSN", "");
            mlhcWriter.CreateSection("SELLER_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // SELLER_DPS
            mlhcWriter.CloseSection(); // SELLER_INFO

            mlhcWriter.CreateSection("BUYER_BORROWER");
            mlhcWriter.WriteElement("BUYER1_FIRST_NAME", "");
            mlhcWriter.WriteElement("BUYER1_MI", "");
            mlhcWriter.WriteElement("BUYER1_LAST_NAME", "");
            mlhcWriter.WriteElement("BUYER1_SSN", "");
            mlhcWriter.WriteElement("BUYER2_FIRST_NAME", "");
            mlhcWriter.WriteElement("BUYER2_MI", "");
            mlhcWriter.WriteElement("BUYER2_LAST_NAME", "");
            mlhcWriter.WriteElement("BUYER2_SSN", "");
            mlhcWriter.CreateSection("BUYER_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // BUYER_DPS
            mlhcWriter.CloseSection(); // BUYER_BORROWER

            mlhcWriter.CreateSection("PROPERTY_INFO");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("COUNTY", "");
            mlhcWriter.WriteElement("APN", "");
            mlhcWriter.WriteElement("LEGAL_DESC", "");
            mlhcWriter.WriteElement("SPECIAL_INSTR", "");
            mlhcWriter.CloseSection(); // PROPERTY_INFO

            mlhcWriter.CreateSection("LISTING_AGENT_DELIVERY");
            mlhcWriter.WriteElement("LENDER_COMPANY", "");
            mlhcWriter.CreateSection("LENDER_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // LENDER_DPS
            mlhcWriter.CloseSection(); // LISTING_AGENT_DELIVERY

            mlhcWriter.CreateSection("BUYER_AGENT_DELIVERY");
            mlhcWriter.WriteElement("BAGENT_COMPANY", "");
            mlhcWriter.CreateSection("BAGENT_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // BAGENT_DPS
            mlhcWriter.CloseSection(); // BUYER_AGENT_DELIVERY

            mlhcWriter.CreateSection("LENDER_DELIVERY");
            mlhcWriter.WriteElement("LAGENT_COMPANY", "");
            mlhcWriter.CreateSection("LAGENT_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // LAGENT_DPS
            mlhcWriter.CloseSection(); // LENDER_DELIVERY

            mlhcWriter.CreateSection("BORROWER_DELIVERY");
            mlhcWriter.WriteElement("BORROWER_COMPANY", "");
            mlhcWriter.CreateSection("BORROWER_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // BORROWER_DPS
            mlhcWriter.CloseSection(); // BORROWER_DELIVERY

            mlhcWriter.CreateSection("OTHER1_DELIVERY");
            mlhcWriter.WriteElement("OTHER1_COMPANY", "");
            mlhcWriter.CreateSection("OTHER1_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // OTHER1_DPS
            mlhcWriter.CloseSection(); // OTHER1_DELIVERY

            mlhcWriter.CreateSection("OTHER2_DELIVERY");
            mlhcWriter.WriteElement("OTHER2_COMPANY", "");
            mlhcWriter.CreateSection("OTHER2_DPS");
            mlhcWriter.WriteElement("ADDRESS", "");
            mlhcWriter.WriteElement("CITY", "");
            mlhcWriter.WriteElement("STATE", "");
            mlhcWriter.WriteElement("ZIP_CODE", "");
            mlhcWriter.WriteElement("ATTENTION", "");
            mlhcWriter.WriteElement("EMAIL", "");
            mlhcWriter.WriteElement("WORK_PHONE", "");
            mlhcWriter.WriteElement("WORK_EXT", "");
            mlhcWriter.WriteElement("FAX", "");
            mlhcWriter.WriteElement("HOME_PHONE", "");
            mlhcWriter.WriteElement("CELL_PHONE", "");
            mlhcWriter.WriteElement("OTHER_PHONE", "");
            mlhcWriter.WriteElement("NO_COPIES", "");
            mlhcWriter.WriteElement("COPIES_CCR", "");
            mlhcWriter.WriteElement("EXCEPTION_COPIES", "");
            mlhcWriter.WriteElement("DELIVERY_TYPE", "");
            mlhcWriter.CloseSection(); // OTHER2_DPS
            mlhcWriter.CloseSection(); // OTHER2_DELIVERY

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