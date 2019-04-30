using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyNews.APIRequestService.DTOs
{
    public class NewsDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string PubDate { get; set; }

        public string ImageURL { get; set; }

        public string ImageALT { get; set; }
    }
}