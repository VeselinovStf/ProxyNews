using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RssReader.ModelFactory.WElementInterpretator.Abstract
{
    public interface IXelementToDateTime
    {
        DateTime Get(string elementName, XElement element);
    }
}