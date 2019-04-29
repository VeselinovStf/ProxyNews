using RssReader.ModelFactory.Validator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.ModelFactory.Validator
{
    public class ModelFactoryStringValidator : IModelFactoryStringValidator
    {
        public string StringIsNullOrWhiteSpace(string str, string modelFieldName)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException($"Invalid RSS Model Parameter : {modelFieldName}");
            }

            return str;
        }
    }
}