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

        public BaseRssFeed ValidateRssFeedModel(BaseRssFeed x)
        {
            try
            {
                return new BaseRssFeed()
                {
                    Title = this.factoryStringValidator.StringIsNullOrWhiteSpace(x.Title, "Title"),
                    Link = this.factoryStringValidator.StringIsNullOrWhiteSpace(x.Link, "Link"),
                    Description = this.factoryStringValidator.StringIsNullOrWhiteSpace(x.Description, "Description"),
                    PubDate = this.factoryStringValidator.StringIsNullOrWhiteSpace(x.PubDate, "PubDate"),
                    ImageALT = x.ImageALT,
                    ImageSRC = x.ImageSRC
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}