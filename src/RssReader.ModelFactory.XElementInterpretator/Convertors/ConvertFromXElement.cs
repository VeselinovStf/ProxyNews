using RssReader.ModelFactory.WElementInterpretator.Abstract;
using RssReaderDateTimeWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace RssReader.ModelFactory.XElementInterpretator.Convertors
{
    public class ConvertFromXElement : IXElementToString, IXElementToImageProps, IXelementToDateTime
    {
        private readonly IDateTimeParser dateTimeParser;

        public ConvertFromXElement(IDateTimeParser dateTimeParser)
        {
            this.dateTimeParser = dateTimeParser;
        }

        public string Get(string elementName, XElement element)
        {
            return (string)element.Element(elementName);
        }

        //TODO: FIX IMAGE RSS - EXPAND THIS FUNCTION - Create specific implementations for any RSS address
        public string GetFrom(string elementName, XElement element)
        {
            //TODO: This is for testing !!!
            //This case is for first api
            try
            {
                var test = element.Element("enclosure").Attribute("url");

                if (test != null)
                {
                    return test.Value;
                }
            }
            catch (Exception)
            {
                //This case is for second
                var t2 = element.Element("description").Value;
                var imgStartIndex = t2.IndexOf("src=\"") + 5;

                StringBuilder resultUrl = new StringBuilder();
                for (int i = imgStartIndex; i < t2.Length; i++)
                {
                    if (t2[i] == '"')
                    {
                        break;
                    }
                    else
                    {
                        resultUrl.Append(t2[i]);
                    }
                }

                return resultUrl.ToString();
            }

            throw new ArgumentException("Boom...");
        }

        DateTime IXelementToDateTime.Get(string elementName, XElement element)
        {
            var elementDateTime = element.Element(elementName).Value;

            try
            {
                //TODO : Remove hard Coded format for dateTime
                var convertedToDateTime = this.dateTimeParser.Parse(elementDateTime, "ddd, dd MMM yyyy HH:mm:ss zzz", CultureInfo.InvariantCulture);

                return convertedToDateTime;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't parse DateTime");
            }
        }
    }
}