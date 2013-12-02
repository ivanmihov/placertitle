using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    public class DataQuickResponse
    {
        /****************************
         *  Attributes
         *  *************************/

        /// <summary>
        /// Number of addresses returned
        /// </summary>
        public int Count
        {
            get
            {
                return m_nNumResults;
            }
        }

        /// <summary>
        /// Property Address
        /// </summary>
        public string Address
        {
            get
            {
                return m_strAddress;
            }
        }

        /// <summary>
        /// Property City
        /// </summary>
        public string City
        {
            get
            {
                return m_strCity;
            }
        }

        /// <summary>
        /// Property State
        /// </summary>
        public string State
        {
            get
            {
                return m_strState;
            }
        }

        /// <summary>
        /// Property Zip
        /// </summary>
        public string Zip
        {
            get
            {
                return m_strZip;
            }
        }

        /// <summary>
        /// Property Assessor's Parcel Number
        /// </summary>
        public string APN
        {
            get
            {
                return m_strAPN;
            }
        }

        /// <summary>
        /// Property County
        /// </summary>
        public string County
        {
            get
            {
                return m_strCounty;
            }
        }

        /// <summary>
        /// Owner 1 First Name
        /// </summary>
        public string Owner1First
        {
            get
            {
                return m_strOwner1First;
            }
        }

        /// <summary>
        /// Owner 1 Last Name
        /// </summary>
        public string Owner1Last
        {
            get
            {
                return m_strOwner1Last;
            }
        }

        /// <summary>
        /// Owner 2 First Name
        /// </summary>
        public string Owner2First
        {
            get
            {
                return m_strOwner2First;
            }
        }

        /// <summary>
        /// Owner 2 Last Name
        /// </summary>
        public string Owner2Last
        {
            get
            {
                return m_strOwner2Last;
            }
        }

        /****************************
         * Methods
         * **************************/
        /// <summary>
        /// Create a new DataQuickResponse object. Once created, use the Read() method to itterate through
        /// each result. Each time Read() is called the class attributes are updated.
        /// </summary>
        /// <param name="strAddress">Street address to send to DataQuick</param>
        /// <param name="strZip">Zip code to send to DataQuick</param>
        public DataQuickResponse(string strAddress, string strZip)
        {
            // Pull Dataquick connection configuration settings
            string strPassword = ConfigurationManager.AppSettings["dataQuickPassword"];
            string strUrl = ConfigurationManager.AppSettings["dataQuickUrl"];
            string strUsername = ConfigurationManager.AppSettings["dataQuickUsername"];
            int nMax = Int32.Parse(ConfigurationManager.AppSettings["dataQuickMax"]);

            // Setup XML reader preferences
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            // Create reader object
            // Test URL: http://xmlservices.dataquick.com/UrlListener.aspx?ActionType=Search&Login=18486a99&Password=lender&OwnerFirst=&OwnerLast=&Address=3rd%20Ave&City=&State=&County=&Zip=95817&AddressType=Site&SearchType=UntilFound&DoCount=true&DoSearch=true&UsagePaging=false&MaxProp=99
            m_xReader = XmlReader.Create(String.Format("{0}?ActionType=Search&Login={1}&Password={2}&OwnerFirst=&"
                + "OwnerLast=&Address={3}&City=&State=&County=&Zip={4}&AddressType=Site&SearchType=UntilFound&DoCount=true&"
                + "DoSearch=true&UsagePaging=false&MaxProp={5}",
                strUrl, strUsername, strPassword, strAddress, strZip, nMax), settings);

            while (m_xReader.Read() && m_xReader.Name != "RESPONSE_DATA") ;

            // Advance to PROPERTY_INFORMATION_RESPONSE_ext
            m_xReader.Read();

            // Advance to _MATCH_ext _Type
            m_xReader.Read();

            // Pull the result count
            try
            {
                int nResults = Int32.Parse(m_xReader.GetAttribute(1));
                m_nNumResults = nResults > nMax ? nMax : nResults;
            }
            catch
            {
                m_nNumResults = 0;
            }

            // Initialize variables
            m_strAddress = "";
            m_strCity = "";
            m_strState = "";
            m_strZip = "";
            m_strAPN = "";
            m_strCounty = "";
            m_strOwner1Last = "";
            m_strOwner1First = "";
            m_strOwner2Last = "";
            m_strOwner2First = "";
        }

        /// <summary>
        /// Read next address result and update address-related attributes.
        /// </summary>
        /// <returns>True if successful, false if error</returns>
        public bool Read()
        {
            bool bSuccess = m_xReader.Read();

            // For converting response to proper case
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            // If node name is not PROPERTY then there is an error
            if (m_xReader.NodeType == XmlNodeType.Element && m_xReader.Name == "PROPERTY")
            {
                // Go to site address node
                m_xReader.Read();

                // Pull address values
                m_strAddress = textInfo.ToTitleCase(m_xReader.GetAttribute("_StreetAddress").ToLower());
                m_strCity = textInfo.ToTitleCase(m_xReader.GetAttribute("_City").ToLower());
                m_strState = m_xReader.GetAttribute("_State");
                m_strZip = m_xReader.GetAttribute("_PostalCode");
                if (m_xReader.GetAttribute("_PlusFourPostalCode") != "")
                    m_strZip += String.Format("-{0}",
                        m_xReader.GetAttribute("_PlusFourPostalCode"));

                // Go to  mail address node
                m_xReader.Read();

                // Go to identification node
                m_xReader.Read();

                // Pull identification values
                m_strAPN = m_xReader.GetAttribute("AssessorsParcelIdentifier");
                m_strCounty = textInfo.ToTitleCase(m_xReader.GetAttribute("MunicipalityName").ToLower());

                // Go to owner node
                m_xReader.Read();

                // Go to name node
                m_xReader.Read();

                // Pull owner 1 name values
                m_strOwner1First = textInfo.ToTitleCase(m_xReader.GetAttribute("_FirstName").ToLower());
                m_strOwner1Last = textInfo.ToTitleCase(m_xReader.GetAttribute("_LastName").ToLower());

                // Go to spouse start node
                m_xReader.Read();

                // Go to spouse name node
                m_xReader.Read();

                // Pull owner 2 name values if spouse present
                m_strOwner2First = textInfo.ToTitleCase(m_xReader.GetAttribute("_FirstName").ToLower());
                m_strOwner2Last = m_strOwner2First != "" ? m_strOwner1Last : "";

                // Go to end of spouse node
                while (m_xReader.Read() && m_xReader.NodeType != XmlNodeType.EndElement) ;

                // Go to end of owner node
                while (m_xReader.Read() && m_xReader.NodeType != XmlNodeType.EndElement) ;

                // Go to next owner start node
                m_xReader.Read();

                // Go to name node
                m_xReader.Read();

                // Pull secondary owner information (overrides first owner spouse)
                m_strOwner2First = textInfo.ToTitleCase(m_xReader.GetAttribute("_FirstName").ToLower());
                m_strOwner2Last = textInfo.ToTitleCase(m_xReader.GetAttribute("_LastName").ToLower());

                // Skip over secondary spouse information
                while (m_xReader.Read() && m_xReader.NodeType != XmlNodeType.EndElement) ;

                // Go to end of second owner node
                while (m_xReader.Read() && m_xReader.NodeType != XmlNodeType.EndElement) ;

                // Go to the property end node
                m_xReader.Read();

            }
            else
                bSuccess = false;

            return bSuccess;
        }

        // Private class members
        private XmlReader m_xReader;
        private int m_nNumResults;
        private string m_strAddress;
        private string m_strCity;
        private string m_strState;
        private string m_strZip;
        private string m_strAPN;
        private string m_strCounty;
        private string m_strOwner1Last;
        private string m_strOwner1First;
        private string m_strOwner2Last;
        private string m_strOwner2First;
    }
}