using RssReader.ModelFactory.WElementInterpretator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RssReader.ModelFactory.XElementInterpretator.Convertors
{
    public class ConvertFromXElement : IXElementToString, IXElementToImageProps
    {
        public string Get(string elementName, XElement element)
        {
            return (string)element.Element(elementName);
        }

        //TODO: FIX IMAGE RSS
        public string GetFrom(string elementName, XElement element)
        {
            var test = element.Element("enclosure").Attribute("url");

            return test.Value;
        }
    }
}