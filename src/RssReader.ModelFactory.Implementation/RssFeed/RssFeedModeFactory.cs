using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.Models.Implementations;
using RssReader.ModelFactory.Validator.Abstract;
using Microsoft.Extensions.Logging;
using RssReader.ModelFactory.WElementInterpretator.Abstract;
using RssReader.ModelFactory.Format.Abstract;
using System.Threading.Tasks;

namespace Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed
{
    public class RssFeedModeFactory : IRssReaderModelFactory<BaseRssFeed>
    {
        private readonly IModelFactoryValidator<BaseRssFeed> modelFactoryValidator;
        private readonly ILogger<RssFeedModeFactory> logger;
        private readonly IXelementModelInterpretator<BaseRssFeed> xElementToModel;
        private readonly IModelFactoryModelFormat<BaseRssFeed> modelFormatter;

        public RssFeedModeFactory(
            IModelFactoryValidator<BaseRssFeed> modelFactoryValidator,
            ILogger<RssFeedModeFactory> logger,
            IXelementModelInterpretator<BaseRssFeed> xElementToModel,
            IModelFactoryModelFormat<BaseRssFeed> modelFormatter)
        {
            this.modelFactoryValidator = modelFactoryValidator;
            this.logger = logger;
            this.xElementToModel = xElementToModel;
            this.modelFormatter = modelFormatter;
        }

        //TODO: EDIT IN FUTURE
        /// <summary>
        /// API DEMO METHOD
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BaseRssFeed>> Create(IEnumerable<XElement> elements)
        {
            var RSSFeedData = (from x in elements
                               select new BaseRssFeed
                               {
                                   Title = ((string)x.Element("title")),
                                   Link = ((string)x.Element("link")),
                                   Description = ((string)x.Element("description")),
                                   
                               });

            return RSSFeedData;
        }
    }
}