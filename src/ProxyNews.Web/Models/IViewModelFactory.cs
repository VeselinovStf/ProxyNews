using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Web.Models.NewsModels;

namespace ProxyNews.Web.Models
{
    public interface IViewModelFactory
    {
        NewsListModel Create(NewsListDTO serviceModel);
    }
}