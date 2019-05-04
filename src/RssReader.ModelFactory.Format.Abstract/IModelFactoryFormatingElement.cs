﻿using RssReaderConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.ModelFactory.Format.Abstract
{
    public interface IModelFactoryFormatingElement
    {
        IList<string> GetFormatElements();
    }
}