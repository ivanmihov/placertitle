using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    /// <summary>
    /// Structure for storing items in a drop-down list that have been read from an MLHC XML file
    /// </summary>
    public struct MLHC_ListItem
    {
        public string Code;
        public string Description;
    }

    public static class MLHC_XmlTools
    {
        /// <summary>
        /// Used for reading a list of possible values that a user can select from in a drop-down box.
        /// The xml format should have a collection of nodes with two sub-nodes each (code and description)
        /// </summary>
        /// <param name="fileName">Relative path to the xml file</param>
        /// <param name="nodeName">Name of the parent node that contains the two sub-nodes with code and description</param>
        /// <returns>Collection of results (Code & Description)</returns>
        public static List<MLHC_ListItem> ReadXmlList(string fileName, string nodeName)
        {
            var xmlValues = new List<MLHC_ListItem>();
            MLHC_ListItem result; // store individual result to add to returned list

            // Open XML file and test output
            FileStream xmlFile = new FileStream(fileName, FileMode.Open);
            using (XmlReader xmlReader = XmlReader.Create(xmlFile))
            {
                while (xmlReader.Read())
                {
                    result = new MLHC_ListItem();

                    // Skip to first text node and read value into id
                    while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                    result.Code = xmlReader.Value;

                    // Skip to next text node and read value into description
                    while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                    result.Description = xmlReader.Value;

                    xmlValues.Add(result);
                }
            }

            return xmlValues;
        }
    }
}