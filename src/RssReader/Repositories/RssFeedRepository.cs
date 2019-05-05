using Utility.RssReading.RssReader.Abstract;
using Utility.RssReading.RssReader.Model.Abstract;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.Models.Implementations;
using Utility.RssReading.RssReader.WebClientWrapper.Abstract;
using Utility.RssReading.RssReader.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.RssReading.RssReader.Repositories
{
    public class RssFeedRepository : IRssReaderRepository<IRssFeed>
    {
        private readonly IWebClientWrapper webClient;
        private readonly IXDocumentParseWrapper xDocument;
        private readonly IRssReaderModelFactory<BaseRssFeed> rssFeedModelFactory;
        private readonly IRssReaderFeed feedDb;

        public RssFeedRepository(
            IWebClientWrapper webClient,
            IXDocumentParseWrapper xDocument,
            IRssReaderModelFactory<BaseRssFeed> rssFeedModelFactory,
            IRssReaderFeed feedDb)
        {
            this.webClient = webClient;
            this.xDocument = xDocument;
            this.rssFeedModelFactory = rssFeedModelFactory;
            this.feedDb = feedDb;
        }

        public async Task<IEnumerable<IEnumerable<IRssFeed>>> GetListedFeed(string descendantElementName)
        {
            var rssFeed = this.feedDb.GetFeed();

            var RSSFeedData = new List<List<BaseRssFeed>>();

            foreach (var feed in rssFeed)
            {
                var RSSData = this.webClient.DownloadString(feed.URL);

                var xml = this.xDocument.Parse(RSSData);

                var a = await this.rssFeedModelFactory
                    .Create(xml.Descendants(descendantElementName));

                RSSFeedData.Add(a.ToList());
            }

            return RSSFeedData;
        }

        public async Task<IEnumerable<IRssFeed>> GetSpecificFeed(string RSSURL, string descendantElementName)
        {
            var RSSData = this.webClient.DownloadString(RSSURL);

            var xml = this.xDocument.Parse(RSSData);

            var RSSFeedData = await this.rssFeedModelFactory
                .Create(xml.Descendants(descendantElementName));

            return RSSFeedData;
        }
    }
}