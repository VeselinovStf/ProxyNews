using Newtonsoft.Json;
using ProxyNews.Json.ModelFactory.Abstract;
using ProxyNews.Json.Models;
using System;
using System.Collections.Generic;

namespace ProxyNews.Json.ModelFactory
{
    public class JsonModelFactory : IJsonDeserializer
    {
        public NewsJsonListModel Deserialize(string input)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<NewsJsonListModel>(input);

                return model;
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Json Convert Exception");
            }
        }
    }
}