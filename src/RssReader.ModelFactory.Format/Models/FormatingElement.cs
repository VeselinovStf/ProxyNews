using RssReader.ModelFactory.Format.Abstract;
using RssReaderConfigurations;
using RssReaderJsonConfigReader.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.ModelFactory.Format.Models
{
    public class FormatingElement : IModelFactoryFormatingElement
    {
        public FormatingElement(IConvertJson<FormattingElements> jsonConfig, IFormatConvert<FormattingElements> formats)
        {
            this.jsonConfig = jsonConfig;
            this.formats = formats;
        }

        private readonly IConvertJson<FormattingElements> jsonConfig;
        private readonly IFormatConvert<FormattingElements> formats;

        public IList<string> GetFormatElements()
        {
            return this.formats.JsonModelToString(
                this.jsonConfig.GetContent(ConfigJsonFileNameConst.FORMATTING_JSON)
                );
        }
    }
}