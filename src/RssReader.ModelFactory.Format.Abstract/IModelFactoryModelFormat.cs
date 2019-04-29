using System;

namespace RssReader.ModelFactory.Format.Abstract
{
    public interface IModelFactoryModelFormat<T>
    {
        T Trim(T model);
    }
}