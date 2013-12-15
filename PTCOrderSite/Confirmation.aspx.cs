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
            mlhcWriter.WriteElement("REF_NUMBER", Request.Form["ctl00$body$GeneralInformation_content$referenceNum"]);
            mlhcWriter.WriteElement("DUE_DATE", "");
            mlhcWriter.WriteElement("CONTACT_ENTERING", Request.Form["ctl00$body$GeneralInformation_content$personEnterOrder"]);
            mlhcWriter.WriteElement("YOU_ARE", Request.Form["ctl00$body$GeneralInformation_content$youAreThe"]);
            mlhcWriter.WriteElement("TRANSACTION_TYPE", Request.Form["ctl00$body$GeneralInformation_content$transactionType"]);
            mlhcWriter.WriteElement("PRODUCT", "");
            mlhcWriter.WriteElement("ENDORSEMENTS", "");
            mlhcWriter.CloseSection(); // GENERAL_INFO

            mlhcWriter.CreateSection("ESCROW_INFO");
            mlhcWriter.WriteElement("OFFICE", Request.Form["ctl00$body$EscrowInformation_content$office"]);
            mlhcWriter.WriteElement("ESCROW_OFFICER", Request.Form["ctl00$body$EscrowInformation_content$escrowOfficer"]);
            mlhcWriter.WriteElement("EST_CLOSING_DATE", Request.Form["ctl00$body$EscrowInformation_content$estClosingDate"]);
            mlhcWriter.WriteElement("POLICY_TYPE", Request.Form["ctl00$body$EscrowInformation_content$policyType"]);
            mlhcWriter.CloseSection(); // ESCROW_INFO

            mlhcWriter.CreateSection("ESCROW_TERMS");
            mlhcWriter.WriteElement("PURCHASE_PRICE", Request.Form["ctl00$body$EscrowTerms_content$purchasePrice"]);
            mlhcWriter.WriteElement("EARNEST_MONEY", Request.Form["ctl00$body$EscrowTerms_content$moneyDeposit"]);
            mlhcWriter.WriteElement("LISTING_PERCENT", Request.Form["ctl00$body$EscrowTerms_content$listingCompany"]);
            mlhcWriter.WriteElement("LISTING_AND_OR", Request.Form["ctl00$body$EscrowTerms_content$listingCompanyAndOr"]);
            mlhcWriter.WriteElement("SELLING_PERCENT", Request.Form["ctl00$body$EscrowTerms_content$sellingCompany"]);
            mlhcWriter.WriteElement("SELLING_AND_OR", Request.Form["ctl00$body$EscrowTerms_content$sellingCompanyAndOr"]);
            mlhcWriter.CreateSection("WHO_PAYS");
            mlhcWriter.WriteElement("TITLE", Request.Form["ctl00$body$WhoPays_content$title"]);
            mlhcWriter.WriteElement("ESCROW", Request.Form["ctl00$body$WhoPays_content$escrow"]);
            mlhcWriter.WriteElement("TRANSFER_TAX", Request.Form["ctl00$body$WhoPays_content$transferTax"]);
            mlhcWriter.WriteElement("HOME_ASSOC", Request.Form["ctl00$body$WhoPays_content$homeownersAssoc"]);
            mlhcWriter.WriteElement("HOME_ASSOC_NAME", Request.Form["ctl00$body$WhoPays_content$homeownersAssocName"]);
            mlhcWriter.WriteElement("TRANSFER_FEE", Request.Form["ctl00$body$WhoPays_content$cityTransferTax"]);
            mlhcWriter.WriteElement("TERMITE_REPORT", Request.Form["ctl00$body$WhoPays_content$termiteReport"]);
            mlhcWriter.WriteElement("TERMITE_WORK", Request.Form["ctl00$body$WhoPays_content$termiteWork"]);
            mlhcWriter.WriteElement("ROOF_REPORT", Request.Form["ctl00$body$WhoPays_content$roofReport"]);
            mlhcWriter.WriteElement("HOME_WARRANTY", Request.Form["ctl00$body$WhoPays_content$homeWarranty"]);
            mlhcWriter.WriteElement("HAZARD", Request.Form["ctl00$body$WhoPays_content$hazardDisclosure"]);
            mlhcWriter.WriteElement("PTC_TO_ORDER", Request.Form["ctl00$body$WhoPays_content$ptcOrder"]);
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
            mlhcWriter.WriteElement("SELLER1_FIRST_NAME", Request.Form["ctl00$body$PropertyInformation_content$txtOwner1First"]);
            mlhcWriter.WriteElement("SELLER1_MI", "");
            mlhcWriter.WriteElement("SELLER1_LAST_NAME", Request.Form["ctl00$body$PropertyInformation_content$txtOwner1Last"]);
            mlhcWriter.WriteElement("SELLER1_SSN", "");
            mlhcWriter.WriteElement("SELLER2_FIRST_NAME", Request.Form["ctl00$body$PropertyInformation_content$txtOwner2First"]);
            mlhcWriter.WriteElement("SELLER2_MI", "");
            mlhcWriter.WriteElement("SELLER2_LAST_NAME", Request.Form["ctl00$body$PropertyInformation_content$txtOwner2Last"]);
            mlhcWriter.WriteElement("SELLER2_SSN", "");
            mlhcWriter.CreateSection("SELLER_DPS");
            mlhcWriter.WriteElement("ADDRESS", Request.Form["ctl00$body$PropertyInformation_content$txtAddress"]);
            mlhcWriter.WriteElement("CITY", Request.Form["ctl00$body$PropertyInformation_content$txtCity"]);
            mlhcWriter.WriteElement("STATE", Request.Form["ctl00$body$PropertyInformation_content$txtState"]);
            mlhcWriter.WriteElement("ZIP_CODE", Request.Form["ctl00$body$PropertyInformation_content$txtZip"]);
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
            mlhcWriter.WriteElement("ADDRESS", Request.Form["ctl00$body$PropertyInformation_content$txtAddress"]);
            mlhcWriter.WriteElement("CITY", Request.Form["ctl00$body$PropertyInformation_content$txtCity"]);
            mlhcWriter.WriteElement("STATE", Request.Form["ctl00$body$PropertyInformation_content$txtState"]);
            mlhcWriter.WriteElement("ZIP_CODE", Request.Form["ctl00$body$PropertyInformation_content$txtZip"]);
            mlhcWriter.WriteElement("COUNTY", Request.Form["ctl00$body$PropertyInformation_content$txtCounty"]);
            mlhcWriter.WriteElement("APN", Request.Form["ctl00$body$PropertyInformation_content$txtAPN"]);
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