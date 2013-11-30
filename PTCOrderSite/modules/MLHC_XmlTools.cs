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
        /// This proceedure assumes that there are always two sub-nodes. The first is the ID and the second
        /// is the description.
        /// </summary>
        /// <param name="fileName">Absoulute path to the xml file</param>
        /// <param name="nErrorCode">0 for success, error code if failure</param>
        /// <returns>Collection of results (Code & Description)</returns>
        public static List<MLHC_ListItem> ReadXmlList(string strFileName, ref int nErrorCode)
        {
            var xmlValues = new List<MLHC_ListItem>();
            nErrorCode = 0;
            MLHC_ListItem result; // store individual result to add to returned list

            // Open XML file and test output
            FileStream xmlFile = new FileStream(strFileName, FileMode.Open);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader xmlReader = XmlReader.Create(xmlFile, settings))
            {
                while (xmlReader.Read())
                {
                    // If at the error tag (will be before any other nodes)
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ERROR")
                    {
                        // Read next node to get error value
                        xmlReader.Read();
                        nErrorCode = Int32.Parse(xmlReader.Value);
                    }
                    // If in any other start node and no error
                    else if (nErrorCode == 0 && xmlReader.NodeType == XmlNodeType.Element
                        && xmlReader.Name != "ROOT")
                    {
                        result = new MLHC_ListItem();

                        // Skip to first text node and read value into id
                        while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                        result.Code = xmlReader.Value;

                        // Skip to next text node and read value into description
                        while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                        result.Description = HttpUtility.UrlDecode(xmlReader.Value);

                        xmlValues.Add(result);
                    }
                }
            }
            xmlFile.Close();
            return xmlValues;
        }
    }
}