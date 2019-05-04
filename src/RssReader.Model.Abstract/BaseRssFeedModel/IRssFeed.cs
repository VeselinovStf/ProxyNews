using System;

namespace Utility.RssReading.RssReader.Model.Abstract
{
    public interface IRssFeed
    {
        string Title { get; set; }

        string Description { get; set; }

        string Link { get; set; }

        DateTime PubDate { get; set; }
    }
}