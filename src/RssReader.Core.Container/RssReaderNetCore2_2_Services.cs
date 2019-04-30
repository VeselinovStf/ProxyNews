using Microsoft.Extensions.DependencyInjection;
using Utility.RssReading.RssReader.Abstract;
using Utility.RssReading.RssReader.Feed;
using Utility.RssReading.RssReader.Model.Abstract;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed;
using Utility.RssReading.RssReader.Models.Implementations;
using Utility.RssReading.RssReader.Repositories;
using Utility.RssReading.RssReader.WebClientWrapper;
using Utility.RssReading.RssReader.WebClientWrapper.Abstract;
using Utility.RssReading.RssReader.XDocumentWrapper;
using Utility.RssReading.RssReader.XDocumentWrapper.Abstract;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using RssReader.ModelFactory.Validator;
using RssReader.ModelFactory.Validator.Abstract;
using RssReader.ModelFactory.WElementInterpretator.Abstract;
using RssReader.ModelFactory.XElementInterpretator.Models.RssFeed;
using RssReader.ModelFactory.Format.Abstract;
using RssReader.ModelFactory.Format.Models.RssFeed;
using RssReader.ModelFactory.Format.Models;
using RssReader.ModelFactory.XElementInterpretator.Convertors;

namespace Utility.RssReading.RssReader.Core.Container
{
    public class RssReaderNetCore2_2_Services
    {
        /// <summary>
        /// Register all RssReader futures and add list of url strings to display from
        ///     "RSS": [
        /// "",
        /// ""
        ///   ]
        /// Add Rss feeds to appsettings.json
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="rssFeeds">Configuratio.GetSection("RSS").Get<IList<string>>());</param>
        public static void RegisterRssReaderServices(IServiceCollection services, IList<string> rssFeeds)
        {
            services.AddScoped<IWebClientWrapper, RssReaderWebClient>();
            services.AddScoped<WebClient, WebClient>();
            services.AddScoped<IXDocumentParseWrapper, RssReaderParseXDocument>();
            services.AddScoped<XDocument, XDocument>();
            services.AddScoped<IRssReaderModelFactory<BaseRssFeed>, RssFeedModeFactory>();
            services.AddScoped<IRssReaderRepository<IRssFeed>, RssFeedRepository>();
            services.AddScoped<IRssReaderFeed, RssReaderFeed>(r => new RssReaderFeed(rssFeeds));
            services.AddScoped<IModelFactoryValidator<BaseRssFeed>, ModelFactoryValidator>();
            services.AddScoped<IModelFactoryStringValidator, ModelFactoryStringValidator>();
            services.AddScoped<IXelementModelInterpretator<BaseRssFeed>, RssFeedXElementModelInterpretator>();
            services.AddScoped<IModelFactoryModelFormat<BaseRssFeed>, RssReaderModelFactoryModelFormat>();
            services.AddScoped<IModelFactoryFormatingElement, FormatingElement>();
            services.AddScoped<IXElementToString, ConvertFromXElement>();
            services.AddScoped<IXElementToImageProps, ConvertFromXElement>();
        }
    }
}