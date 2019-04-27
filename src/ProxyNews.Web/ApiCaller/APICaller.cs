//using Newtonsoft.Json;
//using ProxyNews.Web.Models.NewsModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace ProxyNews.Web.ApiCaller
//{
//    public class APICaller
//    {
//        private readonly IHttpClientFactory _httpClientFactory;

//        public APICaller(IHttpClientFactory httpClientFactory)
//        {
//            this._httpClientFactory = httpClientFactory;
//        }

//        public async Task<List<NewsListModel>> GetAll()
//        {
//            var client = _httpClientFactory.CreateClient();

//            client.BaseAddress = new Uri("https://localhost:44399/api/news");

//            string result = await client.GetStringAsync(client.BaseAddress);

//            return JsonConvert.DeserializeObject<List<NewsListModel>>(result);
//        }
//    }
//}