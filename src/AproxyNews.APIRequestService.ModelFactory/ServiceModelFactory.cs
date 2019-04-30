using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Json.Models;
using System;
using System.Linq;

namespace AproxyNews.APIRequestService.ModelFactory
{
    public class ServiceModelFactory : IServiceModelFactory
    {
        public NewsListDTO Create(NewsJsonListModel jsonModel)
        {
            return new NewsListDTO()
            {
                RssList = jsonModel.RssList.Select(x => x.Select(y => new NewsDTO()
                {
                    Description = y.Description,
                    Link = y.Link,
                    PubDate = y.PubDate,
                    Title = y.Title,
                    ImageALT = y.ImageALT,
                    ImageURL = y.ImageSRC
                }))
            };
        }
    }
}