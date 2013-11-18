using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace PTCOrderSite
{
    public partial class ValidateAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Open XML file and test output
            FileStream xmlFile = new FileStream(Request.PhysicalApplicationPath + "inputSamples\\DataQuickVerification.xml", FileMode.Open);
            using (XmlReader xmlReader = XmlReader.Create(xmlFile))
            {
                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            txtXmlOutput.InnerText += String.Format("Start Element {0}\n", xmlReader.Name);
                            for(int i = 0; i < xmlReader.AttributeCount; i++) {
                                xmlReader.MoveToAttribute(i);
                                txtXmlOutput.InnerText += String.Format("\tAttribute {0} with value {1}\n",
                                    xmlReader.Name, xmlReader.Value);
                            }
                            break;
                        case XmlNodeType.Text:
                            txtXmlOutput.InnerText += String.Format("Text Node: {0}\n", xmlReader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            txtXmlOutput.InnerText += String.Format("End Element {0}\n", xmlReader.Name);
                            break;
                        case XmlNodeType.Whitespace:
                            break;
                        default:
                            txtXmlOutput.InnerText += String.Format("Other node {0} with value {1}\n",
                                xmlReader.NodeType, xmlReader.Value);
                            break;
                    }
                }
            }

            xmlFile.Close();

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