using System;
using System.Xml.Linq;

namespace RssReader.ModelFactory.WElementInterpretator.Abstract
{
    public interface IXelementModelInterpretator<T>
    {
        T XElementToModel(XElement x);
    }
}