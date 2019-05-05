using RssReaderConfigurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ModelFactory.Format.Abstract
{
    public interface IModelFactoryFormatingElement
    {
        IList<string> GetFormatElements();

        Task<IList<string>> GetFormatElementsAsync();
    }
}