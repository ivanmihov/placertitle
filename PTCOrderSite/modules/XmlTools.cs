using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    public static class XmlTools
    {
        public struct XmlResult {
            public string Code;
            public string Description;
        }

        /// <summary>
        /// Used for reading a list of possible values that a user can select from in a drop-down box.
        /// The xml format should have a collection of nodes with two sub-nodes each (code and description)
        /// </summary>
        /// <param name="fileName">Relative path to the xml file</param>
        /// <param name="nodeName">Name of the parent node that contains the two sub-nodes with code and description</param>
        /// <returns>Collection of results (Code & Description)</returns>
        public static List<XmlResult> ReadXmlList(string fileName, string nodeName)
        {
            var xmlValues = new List<XmlResult>();

            // Open XML file and test output
            FileStream xmlFile = new FileStream(fileName, FileMode.Open);
            using (XmlReader xmlReader = XmlReader.Create(xmlFile))
            {
            }

            return xmlValues;
        }
    }
}