using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.RssReading.RssReader.Abstract
{
    public interface IRssReaderFeed
    {
        IEnumerable<IFeedNode> GetFeed();
    }
}