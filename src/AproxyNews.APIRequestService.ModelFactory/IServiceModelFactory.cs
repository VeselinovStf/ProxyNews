using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Json.Models;

namespace AproxyNews.APIRequestService.ModelFactory
{
    public interface IServiceModelFactory
    {
        NewsListDTO Create(NewsJsonListModel jsonModel);
    }
}