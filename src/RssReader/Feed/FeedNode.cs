using System;
using System.Collections.Generic;
using System.Text;
using Utility.RssReading.RssReader.Abstract;

namespace Utility.RssReading.RssReader.Feed
{
    public class FeedNode : IFeedNode
    {
        public string URL { get; set; }
    }
}