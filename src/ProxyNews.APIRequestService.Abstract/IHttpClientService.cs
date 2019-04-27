using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProxyNews.APIRequestService.Abstract
{
    public interface IHttpClientService
    {
        Task<string> GetStringResult(string apiAddress);
    }
}