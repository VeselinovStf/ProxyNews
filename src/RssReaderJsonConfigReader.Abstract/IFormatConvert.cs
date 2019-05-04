using System;
using System.Collections.Generic;
using System.Text;

namespace RssReaderJsonConfigReader.Abstract
{
    public interface IFormatConvert<T>
    {
        IList<string> JsonModelToString(T jsonConvertedModel);
    }
}