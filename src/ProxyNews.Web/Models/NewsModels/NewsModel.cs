﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyNews.Web.Models.NewsModels
{
    public class NewsModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string PubDate { get; set; }
    }
}