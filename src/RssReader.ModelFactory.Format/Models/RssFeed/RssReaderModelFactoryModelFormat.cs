﻿using RssReader.ModelFactory.Format.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility.RssReading.RssReader.Models.Implementations;

namespace RssReader.ModelFactory.Format.Models.RssFeed
{
    public class RssReaderModelFactoryModelFormat : IModelFactoryModelFormat<BaseRssFeed>
    {
        private readonly IModelFactoryFormatingElement formatingElements;

        public RssReaderModelFactoryModelFormat(IModelFactoryFormatingElement formatingElements)
        {
            this.formatingElements = formatingElements;
        }

        public async Task<BaseRssFeed> Trim(BaseRssFeed model)
        {
            foreach (var trimElement in await this.formatingElements.GetFormatElementsAsync())
            {
                model.Description = model.Description.Replace(trimElement, "").Trim();
                model.Link = model.Link.Replace(trimElement, "").Trim();
                model.Title = model.Title.Replace(trimElement, "").Trim();
                model.ImageALT = model.ImageALT.Replace(trimElement, "").Trim();
                model.ImageSRC = model.ImageSRC.Replace(trimElement, "").Trim();
            }

            return model;
        }
    }
}