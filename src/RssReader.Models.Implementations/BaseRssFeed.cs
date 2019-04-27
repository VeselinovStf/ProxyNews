using Utility.RssReading.RssReader.Model.Abstract;

namespace Utility.RssReading.RssReader.Models.Implementations
{
    public class BaseRssFeed : IRssFeed
    {
        public BaseRssFeed()
        {
        }

        public BaseRssFeed(string title, string description, string link)
        {
            this.Title = title;
            this.Description = description;
            this.Link = link;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public string PubDate { get; set; }
    }
}