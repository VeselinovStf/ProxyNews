using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyNews.API.Models
{
    public class RssFeedModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string PubDate { get; set; }

        public string ImageSRC { get; set; }

        public string ImageALT { get; set; }
    }
}