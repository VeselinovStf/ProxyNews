using RssReader.ModelFactory.Validator.Abstract;
using System;
using System.Xml.Linq;
using Utility.RssReading.RssReader.Models.Implementations;

namespace RssReader.ModelFactory.Validator
{
    public class ModelFactoryValidator : IModelFactoryValidator<BaseRssFeed>
    {
        private readonly IModelFactoryStringValidator factoryStringValidator;

        public ModelFactoryValidator(IModelFactoryStringValidator factoryStringValidator)
        {
            this.factoryStringValidator = factoryStringValidator;
        }

        public BaseRssFeed ValidateRssFeedModel(XElement x)
        {
            try
            {
                return new BaseRssFeed()
                {
                    Title = this.factoryStringValidator.StringIsNullOrWhiteSpace((((string)x.Element("title"))), "Title"),
                    Link = this.factoryStringValidator.StringIsNullOrWhiteSpace((((string)x.Element("link"))), "Link"),
                    Description = this.factoryStringValidator.StringIsNullOrWhiteSpace((((string)x.Element("description"))), "Description"),
                    PubDate = this.factoryStringValidator.StringIsNullOrWhiteSpace((((string)x.Element("pubDate"))), "PubDate")
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}