using RssReader.Model.Abstract;
using Utility.RssReading.RssReader.Model.Abstract;

namespace Utility.RssReading.RssReader.Models.Implementations
{
    public class BaseRssFeed : IRssFeed, IRssImage
    {
        public BaseRssFeed()
        {
        }

        public BaseRssFeed(string title, string description, string link, string pubDate)
        {
            this.Title = title;
            this.Description = description;
            this.Link = link;
            this.PubDate = pubDate;
        }

        public BaseRssFeed(
            string title, string description, string link, string pubDate,
            string imageSRC, string imageALT
            )
            : this(title, description, link, pubDate)
        {
            ImageSRC = imageSRC;
            ImageALT = imageALT;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public string PubDate { get; set; }
        public string ImageSRC { get; set; }
        public string ImageALT { get; set; }
    }
}