using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProxyNews.APIRequestService.Abstract
{
    public interface INewsList<T>
    {
        Task<T> GetAll(string apiAddress);
    }
}