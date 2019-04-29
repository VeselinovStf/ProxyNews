using RssReader.ModelFactory.WElementInterpretator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Utility.RssReading.RssReader.Models.Implementations;

namespace RssReader.ModelFactory.XElementInterpretator.Models.RssFeed
{
    public class RssFeedXElementModelInterpretator : IXelementModelInterpretator<BaseRssFeed>
    {
        public BaseRssFeed XElementToModel(XElement x)
        {
            try
            {
                return new BaseRssFeed()
                {
                    Title = (((string)x.Element("title"))),
                    Link = (((string)x.Element("link"))),
                    Description = (((string)x.Element("description"))),
                    PubDate = (((string)x.Element("pubDate")))
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException("XElement to Model Exception");
            }
        }
    }
}