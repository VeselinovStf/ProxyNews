using Newtonsoft.Json;
using RssReader.ModelFactory.Format.Models;
using RssReaderConfigurations;
using RssReaderJsonConfigReader.Abstract;
using System;
using System.Collections.Generic;

namespace RssReaderJsonConfigReader
{
    public class FormatingElementJsonReader : IConvertJson<FormattingElements>
    {
        private readonly IRssReaderJsonReader jsonToString;

        public FormatingElementJsonReader(IRssReaderJsonReader jsonToString)
        {
            this.jsonToString = jsonToString;
        }

        /// <summary>
        /// Deserialize Json file to Specific model
        /// </summary>
        /// <param name="fileName">json file name</param>
        /// <returns></returns>
        public FormattingElements GetContent(string fileName)
        {
            var items = JsonConvert.DeserializeObject<
                FormattingElements>
                    (this.jsonToString.GetJsonAsString(fileName));

            return items;
        }
    }
}