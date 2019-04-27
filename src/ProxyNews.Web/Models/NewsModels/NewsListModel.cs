using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyNews.Web.Models.NewsModels
{
    public class NewsListModel
    {
        public IEnumerable<IEnumerable<NewsModel>> RssList { get; set; }

        public IEnumerable<NewsModel> RssFeed { get; set; }

        public string URL { get; set; }
    }
}