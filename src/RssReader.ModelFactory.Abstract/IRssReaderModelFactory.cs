using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Utility.RssReading.RssReader.ModelFactory.Abstract
{
    public interface IRssReaderModelFactory<T>
    {
        Task<IEnumerable<T>> Create(IEnumerable<XElement> elements);
    }
}