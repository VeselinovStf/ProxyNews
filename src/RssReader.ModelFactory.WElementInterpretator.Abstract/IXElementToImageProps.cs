using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RssReader.ModelFactory.WElementInterpretator.Abstract
{
    public interface IXElementToImageProps
    {
        string GetFrom(string elementName, XElement element);
    }
}