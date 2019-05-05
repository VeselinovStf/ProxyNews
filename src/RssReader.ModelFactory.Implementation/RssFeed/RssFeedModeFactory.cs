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

        public async Task<IEnumerable<BaseRssFeed>> Create(IEnumerable<XElement> elements)
        {
            IList<BaseRssFeed> RSSFeedData = new List<BaseRssFeed>();
            foreach (var e in elements)
            {
                try
                {
                    var modelFromXElement = this.xElementToModel.XElementToModel(e);

                    RSSFeedData.Add(
                        this.modelFactoryValidator.ValidateRssFeedModel(
                            await this.modelFormatter.Trim(modelFromXElement)
                            )
                       );
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