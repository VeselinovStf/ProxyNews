using System;
using System.Collections.Generic;
using System.Text;

namespace RssReaderJsonConfigReader.Abstract
{
    public interface IRssReaderJsonReader
    {
        string GetJsonAsString(string fileName);
    }
}