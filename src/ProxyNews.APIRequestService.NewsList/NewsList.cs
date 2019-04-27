using ProxyNews.APIRequestService.Abstract;
using ProxyNews.APIRequestService.DTOs;
using ProxyNews.HttpClientFactoryWrapper.Abstract;
using ProxyNews.Json.ModelFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyNews.APIRequestService.NewsList
{
    public class NewsList : INewsList<NewsListDTO>
    {
        private readonly IHttpClientFactoryWrapper httpClientFactory;
        private readonly IJsonDeserializer jsonDeserializer;

        public NewsList(
            IHttpClientFactoryWrapper httpClientFactory,
            IJsonDeserializer jsonDeserializer)
        {
            this.httpClientFactory = httpClientFactory;
            this.jsonDeserializer = jsonDeserializer;
        }

        public async Task<NewsListDTO> GetAll(string apiAddress)
        {
            if (this.httpClientFactory.CreateClient())
            {
                if (this.httpClientFactory.SetBaseAddress(new Uri(apiAddress)))
                {
                    var apiCall = await this.httpClientFactory.GetStringAsync();

                    if (string.IsNullOrWhiteSpace(apiCall))
                    {
                        throw new ArgumentException("API CALL STRING FORMAT IS NULL");
                    }

                    var result = this.jsonDeserializer.Deserialize(apiCall);

                    if (result == null)
                    {
                        throw new ArgumentException("DESERIALIZATION FAILED");
                    }

                    var returnModel = new NewsListDTO()
                    {
                        RssList = result.RssList.Select(x => x.Select(y => new NewsDTO()
                        {
                            Description = y.Description,
                            Link = y.Link,
                            PubDate = y.PubDate,
                            Title = y.Title
                        }))
                    };

                    return returnModel;
                }
            }

            throw new ArgumentException("BAD BAD");
        }
    }
}