using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.ModelFactory.Validator.Abstract
{
    public interface IModelFactoryStringValidator
    {
        string StringIsNullOrWhiteSpace(string str, string modelFieldName);
    }
}