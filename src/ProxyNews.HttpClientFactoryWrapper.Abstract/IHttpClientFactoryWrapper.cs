using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProxyNews.HttpClientFactoryWrapper.Abstract
{
    public interface IHttpClientFactoryWrapper
    {
        bool CreateClient();

        bool SetBaseAddress(Uri address);

        Task<string> GetStringAsync();
    }
}