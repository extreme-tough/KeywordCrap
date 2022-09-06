using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Collections;
using System.IO;

namespace KeywordCrap.ClassLib
{
    class ControlsInfo
    {
        private string m_ControlsXMLData;
        public ControlsInfo()
        {
            m_ControlsXMLData = Properties.Resources.ControlsInfo;
        }
        public Hashtable GetAllControlMessages()
        {
            Hashtable retTable = new Hashtable();
            XmlTextReader xmlContent = new XmlTextReader(new System.IO.StringReader(m_ControlsXMLData));
            string key="", value="";

            while (xmlContent.Read())
            {
                if (xmlContent.Name == "control")
                {
                    key = xmlContent.ReadString();
                }
                if (xmlContent.Name == "message")
                {
                    value = xmlContent.ReadString();
                    retTable.Add(key, value);
                    key = "";
                    value = "";
                }
            }
            return retTable;
        }
    }
}
