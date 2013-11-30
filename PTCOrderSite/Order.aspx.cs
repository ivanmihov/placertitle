using PTCOrderSite.modules;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            // Initialize the escrow offices if it hasn't been done yet
            if (m_escrowOffices == null)
                m_escrowOffices = new EscrowOffices(Request.PhysicalApplicationPath
                    + ConfigurationManager.AppSettings["xmlInputDirectory"] + '\\'
                    + ConfigurationManager.AppSettings["xmlEscrowOfficers"]);

            // Load Drop-Downs if it hasn't been done already
            if (Boolean.Parse(hdnLoadedDropDownValues.Value) == false)
            {
                hdnLoadedDropDownValues.Value = true.ToString();

                string strXmlFolder = ConfigurationManager.AppSettings["xmlInputDirectory"];

                loadDropDownElements(transactionType, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlTransactionTypes"]);
                loadDropDownElements(policyType, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlPolicyTypes"]);
                loadDropDownElements(cityTransferTax, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysCityTransferTax"]);
                loadDropDownElements(title, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysTitle"]);
                loadDropDownElements(escrow, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysEscrow"]);
                loadDropDownElements(transferTax, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysTransferTax"]);
                loadDropDownElements(termiteReport, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysTermiteReport"]);
                loadDropDownElements(termiteWork, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysTermiteWork"]);
                loadDropDownElements(roofReport, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysRoofReport"]);
                loadDropDownElements(homeWarranty, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysHomeWarranty"]);
                loadDropDownElements(hazardDisclosure, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysHazardDisclosure"]);
                loadDropDownElements(ptcOrder, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlPtcOrderHazard"]);

                // Load escrow office and escrow officer boxes
                loadDropDownElements(office, m_escrowOffices.GetOffices());
                loadDropDownElements(escrowOfficer, m_escrowOffices.GetOfficers(office.SelectedValue));
            }

            // Pull information from prior form
            txtOwner1First.Text = Request.Form["ctl00$body$selectedOwner1First"];
            txtOwner1Last.Text = Request.Form["ctl00$body$selectedOwner1Last"];
            txtOwner2First.Text = Request.Form["ctl00$body$selectedOwner2First"];
            txtOwner2Last.Text = Request.Form["ctl00$body$selectedOwner2Last"];
            txtAddress.Text = Request.Form["ctl00$body$selectedAddress"];
            txtAPN.Text = Request.Form["ctl00$body$selectedAPN"];
            txtCity.Text = Request.Form["ctl00$body$selectedCity"];
            txtCounty.Text = Request.Form["ctl00$body$selectedCounty"];
            txtState.Text = Request.Form["ctl00$body$selectedState"];
            txtZip.Text = Request.Form["ctl00$body$selectedZip"];
        }

        /// <summary>
        /// Submit button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        /// <summary>
        /// Escrow office drop-down list, selected index changed event handler. Re-populates list of
        /// escrow officers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void office_SelectedIndexChanged(object sender, EventArgs e)
        {
            escrowOfficer.Items.Clear();

            loadDropDownElements(escrowOfficer, m_escrowOffices.GetOfficers(office.SelectedValue));
        }

        /// <summary>
        /// Call this to load the id's and descriptions into the drop-down list from a given XML file
        /// </summary>
        /// <param name="ctrlListControl">The control to be populated, should be a DropDownList</param>
        /// <param name="strInputFile">The location of the XML file</param>
        private void loadDropDownElements(Control ctrlListControl, string strInputFile)
        {
            if (ctrlListControl is DropDownList)
            {
                DropDownList drpList = (DropDownList)ctrlListControl;
                int nErrorCode = 0;
                foreach (MLHC_ListItem result in MLHC_XmlTools.ReadXmlList(
                    Request.PhysicalApplicationPath + strInputFile, ref nErrorCode))
                {
                    ListItem item = new ListItem(result.Description, result.Code);
                    drpList.Items.Add(item);
                }
                if (nErrorCode != 0)
                    Response.Redirect(String.Format("~/Error.aspx?Error={0}&File={1}", nErrorCode, strInputFile));
            }
        }

        /// <summary>
        /// Loads drop down control with items from a given collection of mlhc list box items
        /// </summary>
        /// <param name="ctrlListControl">control to populate</param>
        /// <param name="items">items to add to it</param>
        private void loadDropDownElements(Control ctrlListControl, List<MLHC_ListItem> items)
        {
            if (ctrlListControl is DropDownList)
            {
                DropDownList drpList = (DropDownList)ctrlListControl;
                foreach (MLHC_ListItem item in items)
                {
                    ListItem listItem = new ListItem();
                    listItem.Text = item.Description;
                    listItem.Value = item.Code;
                    drpList.Items.Add(listItem);
                }
            }
        }

        private EscrowOffices m_escrowOffices;
    }
}