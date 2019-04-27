using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.Models.Implementations;

namespace Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed
{
    public class RssFeedModeFactory : IRssReaderModelFactory<BaseRssFeed>
    {
        public IEnumerable<BaseRssFeed> Create(IEnumerable<XElement> elements)
        {
            var RSSFeedData = (from x in elements
                               select new BaseRssFeed
                               {
                                   Title = ((string)x.Element("title")),
                                   Link = ((string)x.Element("link")),
                                   Description = ((string)x.Element("description")),
                                   PubDate = ((string)x.Element("pubDate"))
                               });

            return RSSFeedData;
        }
    }
}