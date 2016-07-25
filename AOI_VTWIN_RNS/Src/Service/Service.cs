﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace AOI_VTWIN_RNS.Src.Service
{
    class Service 
    {
        /// <summary>
        /// Realiza el pedido del service, retorna string XML 
        /// </summary>
        /// <param name="service"></param>
        /// <returns>XML</returns>
        public static IEnumerable<XElement> Consume(string route)
        {
            XDocument xml = Http.Http.LoadXMLFromUrl(route + "?xml");
            return xml.Descendants("service");
        }

        /// <summary>
        /// Lee un tag especifico del archivo XML
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string ReadTag(string tag, IEnumerable<XElement> root)
        {
            string value = null;
            IEnumerable<XElement> elements = root.Elements(tag);
            if (elements.Count() > 0)
            {
                value = elements.First().Value;
            }
            return value;
        }

        public static string ReadTag(IEnumerable<XElement> root)
        {
            return root.First().Value;
        }

        public static string ReadVal(string tag, IEnumerable<XElement> root)
        {
            string value = null;
            IEnumerable<XElement> elements = root.Elements(tag);
            if (elements.Count() > 0)
            {
                value = elements.First().Value;
            }
            return value;
        }
    }
}