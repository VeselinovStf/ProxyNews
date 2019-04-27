using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.RssReading.RssReader.Abstract;

namespace Utility.RssReading.RssReader.Feed
{
    public class RssReaderFeed : IRssReaderFeed
    {
        public readonly IEnumerable<IFeedNode> FeedList;

        public RssReaderFeed(IEnumerable<string> feedList)
        {
            this.FeedList = feedList
                .Select(l => new FeedNode()
                {
                    URL = l
                });
        }

        public IEnumerable<IFeedNode> GetFeed()
        {
            return this.FeedList;
        }
    }
}