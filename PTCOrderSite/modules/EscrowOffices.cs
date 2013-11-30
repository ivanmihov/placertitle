using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    /// <summary>
    /// Stores an escrow office id and name
    /// </summary>
    struct EscrowOffice
    {
        public string strOfficeID;
        public string strOfficeName;
    }

    /// <summary>
    /// Stores the escrow officer's office id, username, and full name
    /// </summary>
    struct EscrowOfficer
    {
        public string strOfficeID;
        public string strUserID;
        public string strUserName;
    }

    /// <summary>
    /// Collection of escrow officers and the offices that they are associated with
    /// </summary>
    public class EscrowOffices
    {
        /// <summary>
        /// Construct a new EscrowOffices object using an xml file
        /// </summary>
        /// <param name="strFileName">Full path for xml file to read</param>
        public EscrowOffices(string strFileName)
        {
            m_escrowOfficers = new List<EscrowOfficer>();
            m_escrowOffices = new List<EscrowOffice>();
            m_nReadError = 0;

            FileStream fsXml = new FileStream(strFileName, FileMode.Open);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader xmlReader = XmlReader.Create(fsXml, settings))
            {
                while (xmlReader.Read())
                {
                    // If at the error tag (will be before any other nodes)
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "ERROR")
                    {
                        // Read next node to get error value
                        xmlReader.Read();
                        m_nReadError = Int32.Parse(xmlReader.Value);
                    }
                    // If at a new office node
                    else if (m_nReadError == 0 && xmlReader.NodeType == XmlNodeType.Element
                        && xmlReader.Name == "OFFICE_ID")
                    {
                        EscrowOffice currentOffice = new EscrowOffice();

                        // Skip to first text node and read value into id
                        while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                        currentOffice.strOfficeID = xmlReader.Value;

                        // Skip to next text node and read value into description
                        while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                        currentOffice.strOfficeName = HttpUtility.UrlDecode(xmlReader.Value);

                        // Read end node
                        xmlReader.Read();

                        m_escrowOffices.Add(currentOffice);

                        // Add escrow officers
                        while (xmlReader.Read() && xmlReader.Name == "ESCROW_OFFICER" && xmlReader.NodeType == XmlNodeType.Element)
                        {
                            EscrowOfficer currentOfficer = new EscrowOfficer();

                            // Set office ID
                            currentOfficer.strOfficeID = currentOffice.strOfficeID;

                            // Skip to first text node and read value into id
                            while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                            currentOfficer.strUserID = xmlReader.Value;

                            // Skip to next text node and read value into description
                            while (xmlReader.Read() && xmlReader.NodeType != XmlNodeType.Text) ;
                            currentOfficer.strUserName = HttpUtility.UrlDecode(xmlReader.Value);

                            // Read user id end element
                            xmlReader.Read();

                            // Read end escrow officer node
                            xmlReader.Read();

                            m_escrowOfficers.Add(currentOfficer);
                        }
                    }
                }
            }

            fsXml.Close();
        }

        /// <summary>
        /// Gets a list of all office values available
        /// </summary>
        /// <returns>List of offices for drop-down list control</returns>
        public List<MLHC_ListItem> GetOffices()
        {
            var offices = new List<MLHC_ListItem>();

            foreach (EscrowOffice office in m_escrowOffices)
            {
                MLHC_ListItem item = new MLHC_ListItem();
                item.Code = office.strOfficeID;
                item.Description = office.strOfficeName;
                offices.Add(item);
            }

            return offices;
        }

        /// <summary>
        /// Gets a list of escrow officers at a given office
        /// </summary>
        /// <param name="strOfficeID">OfficeID to load escrow officers from</param>
        /// <returns>List of escrow officers for drop-down list control</returns>
        public List<MLHC_ListItem> GetOfficers(string strOfficeID)
        {
            var officers = new List<MLHC_ListItem>();

            foreach (EscrowOfficer officer in m_escrowOfficers)
            {
                if (officer.strOfficeID == strOfficeID)
                {
                    MLHC_ListItem item = new MLHC_ListItem();

                    item.Code = officer.strUserID;
                    item.Description = officer.strUserName;
                    officers.Add(item);
                }
            }

            return officers;
        }

        private List<EscrowOffice> m_escrowOffices;
        private List<EscrowOfficer> m_escrowOfficers;
        /// <summary>
        /// Read error from xml file
        /// </summary>
        private int m_nReadError;
    }
}