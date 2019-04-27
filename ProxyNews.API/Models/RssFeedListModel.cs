using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.RssReading.RssReader.Model.Abstract;

namespace ProxyNews.API.Models
{
    public class RssFeedListModel
    {
        public IEnumerable<IEnumerable<IRssFeed>> RssList { get; set; }
    }
}