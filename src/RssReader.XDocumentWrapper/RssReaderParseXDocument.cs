using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Utility.RssReading.RssReader.XDocumentWrapper.Abstract;

namespace Utility.RssReading.RssReader.XDocumentWrapper
{
    public class RssReaderParseXDocument : IXDocumentParseWrapper
    {
        public XDocument Parse(string RSSData)
        {
            return XDocument.Parse(RSSData);
        }
    }
}