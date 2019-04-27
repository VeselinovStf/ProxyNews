using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyNews.Json.Models
{
    public class NewsJsonListModel
    {
        public IEnumerable<IEnumerable<NewsJsonModel>> RssList { get; set; }
    }
}