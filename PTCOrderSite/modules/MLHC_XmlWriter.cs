using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    public class MLHC_XmlWriter
    {
        /// <summary>
        /// Construct a new XmlWriter
        /// </summary>
        /// <param name="strFilename">Filename for Xml file</param>
        public MLHC_XmlWriter(string strFilename)
        {
            // Open file and create new XmlWriter
            FileStream xmlFile = new FileStream(strFilename, FileMode.Create);
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.CloseOutput = true;
            xmlSettings.Indent = true;
            m_xmlWriter = XmlWriter.Create(xmlFile, xmlSettings);

            m_xmlWriter.WriteStartElement("ORDER");
        }

        /// <summary>
        /// Create a new section in the XML file, make sure to call "CloseSection" when done.
        /// You may embed multiple sections in each other
        /// </summary>
        /// <param name="strSectionName">Name of new section (Xml Element)</param>
        public void CreateSection(string strSectionName)
        {
            m_xmlWriter.WriteStartElement(strSectionName);
        }

        /// <summary>
        /// Close a section previous created by calling CreateSection()
        /// </summary>
        public void CloseSection()
        {
            m_xmlWriter.WriteEndElement();
        }

        /// <summary>
        /// Write an Xml element with value (allowed to be empty)
        /// </summary>
        /// <param name="strElementName">Element name</param>
        /// <param name="strElementValue">Element value, pass empty string if empty</param>
        public void WriteElement(string strElementName, string strElementValue)
        {
            m_xmlWriter.WriteStartElement(strElementName);
            if (!String.IsNullOrEmpty(strElementValue))
                m_xmlWriter.WriteValue(strElementValue);
            m_xmlWriter.WriteEndElement();
        }

        /// <summary>
        /// Output ending xml root tag and close file
        /// </summary>
        public void Close()
        {
            m_xmlWriter.WriteEndElement();
            m_xmlWriter.Close();
        }

        private XmlWriter m_xmlWriter;
    }
}