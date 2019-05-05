using Newtonsoft.Json;
using RssReader.ModelFactory.Format.Abstract;
using RssReaderConfigurations;
using RssReaderJsonConfigReader.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ModelFactory.Format.Models
{
    public class FormatingElement : IModelFactoryFormatingElement
    {
        public FormatingElement(
            IConvertJson<FormattingElements> jsonConfig,
            IFormatConvert<FormattingElements> formats)
        {
            this.jsonConfig = jsonConfig;
            this.formats = formats;
        }

        private readonly IConvertJson<FormattingElements> jsonConfig;
        private readonly IFormatConvert<FormattingElements> formats;

        public IList<string> GetFormatElements()
        {
            return this.formats.JsonModelToString(
                this.jsonConfig.GetContent("this function is removed")
                );
        }

        //TODO: Change this to new future
        /// <summary>
        /// Test method for RssReader.API
        /// </summary>
        /// <returns></returns>
        public async Task<IList<string>> GetFormatElementsAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44372");

                var response = await client.GetAsync($"/api/FormatConfiguration");
                var stringResult = await response.Content.ReadAsStringAsync();

                var jsonResult = JsonConvert.DeserializeObject<FormattingElements>(stringResult);

                return this.formats.JsonModelToString(jsonResult);
            }
        }
    }
}