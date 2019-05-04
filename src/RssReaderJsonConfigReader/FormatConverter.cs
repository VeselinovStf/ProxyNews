using RssReaderConfigurations;
using RssReaderJsonConfigReader.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReaderJsonConfigReader
{
    public class FormatConverter : IFormatConvert<FormattingElements>
    {
        /// <summary>
        /// Add Formating Item From Parsed Json
        /// </summary>
        /// <param name="jsonConvertedModel">Parset elements from json</param>
        /// <returns></returns>
        public IList<string> JsonModelToString(FormattingElements jsonConvertedModel)
        {
            List<string> values = new List<string>();

            values.Add(jsonConvertedModel.ESCAPE_SIGHN1);
            values.Add(jsonConvertedModel.ESCAPE_SIGHN2);
            values.Add(jsonConvertedModel.ESCAPE_SIGHN3);
            values.Add(jsonConvertedModel.ESCAPE_SIGHN4);
            values.Add(jsonConvertedModel.P_OPPEN_ELEMENTS);
            values.Add(jsonConvertedModel.P_CLOSE_ELEMENTS);
            values.Add(jsonConvertedModel.ESCAPE_SIGHN1);
            values.Add(jsonConvertedModel.STRONG_CLOSE_ELEMENTS);
            values.Add(jsonConvertedModel.STRONG_OPEN_ELEMENTS);

            return values;
        }
    }
}