using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.Models.Implementations;
using RssReader.ModelFactory.Validator.Abstract;
using Microsoft.Extensions.Logging;

namespace Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed
{
    public class RssFeedModeFactory : IRssReaderModelFactory<BaseRssFeed>
    {
        private readonly IModelFactoryValidator<BaseRssFeed> modelFactoryValidator;
        private readonly ILogger<RssFeedModeFactory> logger;

        public RssFeedModeFactory(
            IModelFactoryValidator<BaseRssFeed> modelFactoryValidator,
            ILogger<RssFeedModeFactory> logger)
        {
            this.modelFactoryValidator = modelFactoryValidator;
            this.logger = logger;
        }

        public IEnumerable<BaseRssFeed> Create(IEnumerable<XElement> elements)
        {
            IList<BaseRssFeed> RSSFeedData = new List<BaseRssFeed>();
            foreach (var e in elements)
            {
                try
                {
                    RSSFeedData.Add(this.modelFactoryValidator.ValidateRssFeedModel(e));
                }
                catch (Exception ex)
                {
                    this.logger.LogWarning(ex.Message);
                }
            }

            return RSSFeedData;
        }
    }
}