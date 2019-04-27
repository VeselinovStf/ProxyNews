using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Utility.RssReading.RssReader.ModelFactory.Abstract
{
    public interface IRssReaderModelFactory<T>
    {
        IEnumerable<T> Create(IEnumerable<XElement> elements);
    }
}