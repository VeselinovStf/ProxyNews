using System;

namespace ProxyNews.Json.Models
{
    public class NewsJsonModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public DateTime PubDate { get; set; }

        public string ImageSRC { get; set; }

        public string ImageALT { get; set; }
    }
}