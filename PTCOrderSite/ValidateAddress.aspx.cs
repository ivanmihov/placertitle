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
            // Create DataQuickResponse object
            DataQuickResponse dqResponse = new DataQuickResponse(
                Request.Form["ctl00$body$txtAddress"], Request.Form["ctl00$body$txtZip"]);

            for (int i = 1; dqResponse.Read(); i++ )
            {
                // Create new table row
                TableRow tr = new TableRow();

                // Create new table cell
                TableCell td = new TableCell();

                // Create new radio button
                RadioButton rdButton = new RadioButton();
                if (i == 1)
                    rdButton.Checked = true;

                // Set radio button group and add to cell and add cell to row
                rdButton.GroupName = "AddressSelection";
                rdButton.ID = String.Format("Result_{0}", i);
                rdButton.InputAttributes.Add("onchange", "changeSelection();"); // Add javascript handler
                td.Controls.Add(rdButton);
                tr.Cells.Add(td);

                // Create new table cell
                td = new TableCell();
                td.CssClass = "bottomBorder";

                // Create result area
                Label lblResult = new Label();
                lblResult.ID = String.Format("Result_{0}", i);

                // Create a label for each dataquick response element
                Label lblAddress = new Label();
                Label lblCity = new Label();
                Label lblState = new Label();
                Label lblZip = new Label();
                Label lblCounty = new Label();
                Label lblAPN = new Label();
                Label lblOwner1First = new Label();
                Label lblOwner1Last = new Label();
                Label lblOwner2First = new Label();
                Label lblOwner2Last = new Label();

                // Assign values and ID's to each label
                lblAddress.Text = dqResponse.Address;
                lblAddress.ID = String.Format("{0}_Address", i);
                lblCity.Text = dqResponse.City;
                lblCity.ID = String.Format("{0}_City", i);
                lblState.Text = dqResponse.State;
                lblState.ID = String.Format("{0}_State", i);
                lblZip.Text = dqResponse.Zip;
                lblZip.ID = String.Format("{0}_Zip", i);
                lblCounty.Text = dqResponse.County;
                lblCounty.ID = String.Format("{0}_County", i);
                lblAPN.Text = dqResponse.APN;
                lblAPN.ID = String.Format("{0}_APN", i);
                lblOwner1First.Text = dqResponse.Owner1First;
                lblOwner1First.ID = String.Format("{0}_Owner1First", i);
                lblOwner1Last.Text = dqResponse.Owner1Last;
                lblOwner1Last.ID = String.Format("{0}_Owner1Last", i);
                lblOwner2First.Text = dqResponse.Owner2First;
                lblOwner2First.ID = String.Format("{0}_Owner2First", i);
                lblOwner2Last.Text = dqResponse.Owner2Last;
                lblOwner2Last.ID = String.Format("{0}_Owner2Last", i);

                // Add elements to result area
                if (lblOwner1First.Text != "") // Properties in Trust only return last name
                    AddLabelElement(lblResult, lblOwner1First, " ");
                AddLabelElement(lblResult, lblOwner1Last, "<br />");
                if (lblOwner2First.Text != "")
                {
                    AddLabelElement(lblResult, lblOwner2First, " ");
                    AddLabelElement(lblResult, lblOwner2Last, "<br />");
                }
                AddLabelElement(lblResult, lblAddress, ", ");
                AddLabelElement(lblResult, lblCity, ", ");
                AddLabelElement(lblResult, lblState, " ");
                AddLabelElement(lblResult, lblZip, "<br />");
                AddLabelElement(lblResult, lblCounty, " ");
                AddLabelElement(lblResult, lblAPN, "");

                td.Controls.Add(lblResult);

                tr.Cells.Add(td);

                tblResults.Rows.Add(tr);
            }
        }

        private void AddLabelElement(Label lblParent, Label lblChild, string strSeparator)
        {
            Literal ltSeparator = new Literal();
            ltSeparator.Text = strSeparator;
            lblParent.Controls.Add(lblChild);
            lblParent.Controls.Add(ltSeparator);
        }
    }
}