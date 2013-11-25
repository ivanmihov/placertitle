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
            // Load Drop-Downs if it hasn't been done already
            if (Boolean.Parse(hdnLoadedDropDownValues.Value) == false)
            {
                hdnLoadedDropDownValues.Value = true.ToString();

                string strXmlFolder = ConfigurationManager.AppSettings["XmlInputDirectory"];

                loadDropDownElements(transactionType, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlTransactionTypes"]);
                /*loadDropDownElements(escrowOfficer, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlEscrowOfficers"]);*/
                loadDropDownElements(policyType, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlPolicyTypes"]);
                loadDropDownElements(cityTransferTax, strXmlFolder + '\\'
                    + ConfigurationManager.AppSettings["xmlWhoPaysCityTransferTax"]);
            }
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
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
                foreach (MLHC_ListItem result in MLHC_XmlTools.ReadXmlList(
                    Request.PhysicalApplicationPath + strInputFile))
                {
                    ListItem item = new ListItem(result.Description, result.Code);
                    drpList.Items.Add(item);
                }
            }
        }
    }
}