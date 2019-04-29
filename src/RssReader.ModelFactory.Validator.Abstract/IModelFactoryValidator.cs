using System;
using System.Xml.Linq;

namespace RssReader.ModelFactory.Validator.Abstract
{
    public interface IModelFactoryValidator<T>
    {
        T ValidateRssFeedModel(T x);
    }
}