using System;
using System.Threading.Tasks;

namespace RssReader.ModelFactory.Format.Abstract
{
    public interface IModelFactoryModelFormat<T>
    {
        Task<T> Trim(T model);
    }
}