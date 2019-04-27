using ProxyNews.Json.Models;
using System.Collections.Generic;

namespace ProxyNews.Json.ModelFactory.Abstract
{
    public interface IJsonDeserializer
    {
        NewsJsonListModel Deserialize(string input);
    }
}