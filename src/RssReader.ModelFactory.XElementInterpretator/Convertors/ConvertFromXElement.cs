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
            //return (string)element.Element(elementFrom).Element(elementName);
            // Find all elements that are marked for image and get SRC and ALT
            return "https://cache2.24chasa.bg/Images/Cache/460/Image_7427460_114.jpg";
        }
    }
}