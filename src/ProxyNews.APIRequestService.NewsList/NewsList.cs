using AproxyNews.APIRequestService.ModelFactory;
using ProxyNews.APIRequestService.Abstract;
using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Json.ModelFactory.Abstract;
using System;
using System.Threading.Tasks;

namespace ProxyNews.APIRequestService.NewsList
{
    public class NewsList : INewsList<NewsListDTO>
    {
        private readonly IJsonDeserializer jsonDeserializer;
        private readonly IHttpClientService httpClientFactory;
        private readonly IServiceModelFactory modelFactory;

        public NewsList(
            IJsonDeserializer jsonDeserializer,
            IHttpClientService httpClientFactory,
            IServiceModelFactory modelFactory)
        {
            this.jsonDeserializer = jsonDeserializer;
            this.httpClientFactory = httpClientFactory;
            this.modelFactory = modelFactory;
        }

        public async Task<NewsListDTO> GetAll(string apiAddress)
        {
            try
            {
                var apiCall = await this.httpClientFactory.GetStringResult(apiAddress);

                if (apiCall == null)
                {
                    throw new ArgumentException("API CALL No Result");
                }

                var result = this.jsonDeserializer.Deserialize(apiCall);

                if (result == null)
                {
                    throw new ArgumentException("DESERIALIZATION FAILED");
                }

                var returnModel = this.modelFactory.Create(result);

                //TODO: RETURN MODEL VALIDATION !!!
                //TODO: Format incomming data

                if (returnModel == null)
                {
                    throw new ArgumentException("MODEL CREATION FAILED");
                }

                return returnModel;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}