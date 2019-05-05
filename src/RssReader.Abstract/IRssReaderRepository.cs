using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Utility.RssReading.RssReader.Abstract
{
    public interface IRssReaderRepository<IRssFeed>
    {
        Task<IEnumerable<IEnumerable<IRssFeed>>> GetListedFeed(string descendantElementName);

        Task<IEnumerable<IRssFeed>> GetSpecificFeed(string RSSURL, string descendantElementName);
    }
}