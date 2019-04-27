using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyNews.APIRequestService.DTOs
{
    public class NewsListDTO
    {
        public IEnumerable<IEnumerable<NewsDTO>> RssList { get; set; }
    }
}