using System;

namespace Utility.RssReading.RssReader.WebClientWrapper.Abstract
{
    public interface IWebClientWrapper
    {
        string DownloadString(string RSSURL);
    }
}