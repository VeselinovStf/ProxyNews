using System;
using System.Collections.Generic;

namespace RssReaderJsonConfigReader.Abstract
{
    public interface IConvertJson<T>
    {
        T GetContent(string fileName);
    }
}