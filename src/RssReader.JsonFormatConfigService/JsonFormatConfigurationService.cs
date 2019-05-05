using RssReader.JsonFormatConfigService.Abstract;
using RssReader.JsonFormatConfigService.Dtos;
using RssReaderConfigurations;
using RssReaderJsonConfigReader.Abstract;
using System;

namespace RssReader.JsonFormatConfigService
{
    public class JsonFormatConfigurationService : IJsonFormatConfig
    {
        private readonly IConvertJson<FormattingElements> getElements;

        public JsonFormatConfigurationService(IConvertJson<FormattingElements> getElements)
        {
            this.getElements = getElements;
        }

        public FormatElementsDTO Get(string fileName)
        {
            var elements = this.getElements.GetContent(fileName);

            //Model Creation
            var serviceModel = new FormatElementsDTO()
            {
                STRONG_OPEN_ELEMENTS = elements.STRONG_OPEN_ELEMENTS,
                STRONG_CLOSE_ELEMENTS = elements.STRONG_CLOSE_ELEMENTS,
                ESCAPE_SIGHN1 = elements.ESCAPE_SIGHN1,
                ESCAPE_SIGHN2 = elements.ESCAPE_SIGHN2,
                ESCAPE_SIGHN3 = elements.ESCAPE_SIGHN3,
                ESCAPE_SIGHN4 = elements.ESCAPE_SIGHN4,
                P_CLOSE_ELEMENTS = elements.P_CLOSE_ELEMENTS,
                P_OPPEN_ELEMENTS = elements.P_OPPEN_ELEMENTS
            };

            return serviceModel;
        }
    }
}