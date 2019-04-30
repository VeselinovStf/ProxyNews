using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Web.Models.NewsModels;

namespace ProxyNews.Web.Models
{
    public class ViewModelFactory : IViewModelFactory
    {
        public NewsListModel Create(NewsListDTO serviceModel)
        {
            return new NewsListModel()
            {
                RssList = serviceModel.RssList.Select(x => x.Select(y => new NewsModel()
                {
                    Description = y.Description,
                    Link = y.Link,
                    PubDate = y.PubDate,
                    Title = y.Title,
                    ImageALT = y.ImageALT,
                    ImageSRC = y.ImageURL
                }))
            };
        }
    }
}