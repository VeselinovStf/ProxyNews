using System;
using System.Xml.Linq;

namespace Utility.RssReading.RssReader.XDocumentWrapper.Abstract
{
    public interface IXDocumentParseWrapper
    {
        XDocument Parse(string RSSData);
    }
}