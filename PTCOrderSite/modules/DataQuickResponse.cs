using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;

namespace PTCOrderSite.modules
{
    public class DataQuickResponse
    {
        private string m_strPassword = ConfigurationManager.AppSettings["dataQuickPassword"];
        private string m_strUrl = ConfigurationManager.AppSettings["dataQuickUrl"];
        private string m_strUsername = ConfigurationManager.AppSettings["dataQuickUsername"];

        public DataQuickResponse(string strAddress, string strZip)
        {
            /*XmlDocument xDoc = new XmlDocument();*/

            /* Sample URL: http://xmlservices.dataquick.com/UrlListener.aspx?ActionType=Search&Login=18486a99&Password=lender&OwnerFirst=&OwnerLast=&Address=3142%203rd&City=&State=&County=&Zip=95817&AddressType=Site&SearchType=UntilFound&DoCount=true&DoSearch=true&UsagePaging=false&MaxProp=99 */
            /*xDoc.Load(String.Format("{0}?ActionType=Search&Login={1}&Password={2}&OwnerFirst=&OwnerLast=&Address={3}&"
                + "City=&State=&County=&Zip={4}&AddressType=Site&SearchType=UntilFound&DoCount=true&DoSearch=true&"
                + "UsagePaging=false&MaxProp=99",
                m_strUrl, m_strUsername, m_strPassword, strAddress, strZip));*/

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            XmlReader xReader = XmlReader.Create(String.Format("{0}?ActionType=Search&Login={1}&Password={2}&OwnerFirst=&"
                + "OwnerLast=&Address={3}&City=&State=&County=&Zip={4}&AddressType=Site&SearchType=UntilFound&DoCount=true&"
                + "DoSearch=true&UsagePaging=false&MaxProp=99",
                m_strUrl, m_strUsername, m_strPassword, strAddress, strZip), settings);

            /*
            XmlNodeList xNodeList = xDoc.DocumentElement.SelectNodes("PROPERTY_INFORMATION_RESPONSE_ext");

            foreach (XmlNode xNode in xNodeList)
            {
                ;
            }
             * */
        }
    }
}