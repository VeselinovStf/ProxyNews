using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using Utility.RssReading.RssReader.ModelFactory.Abstract;
using Utility.RssReading.RssReader.Models.Implementations;
using RssReader.ModelFactory.Validator.Abstract;

namespace Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed
{
    public class RssFeedModeFactory : IRssReaderModelFactory<BaseRssFeed>
    {
        private readonly IModelFactoryValidator<BaseRssFeed> modelFactoryValidator;

        public RssFeedModeFactory(IModelFactoryValidator<BaseRssFeed> modelFactoryValidator)
        {
            this.modelFactoryValidator = modelFactoryValidator;
        }

        public IEnumerable<BaseRssFeed> Create(IEnumerable<XElement> elements)
        {
            var RSSFeedData = (from x in elements
                               select this.modelFactoryValidator.ValidateRssFeedModel(x));

            return RSSFeedData;
        }
    }
}