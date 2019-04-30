using RssReader.ModelFactory.WElementInterpretator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Utility.RssReading.RssReader.Models.Implementations;

namespace RssReader.ModelFactory.XElementInterpretator.Models.RssFeed
{
    public class RssFeedXElementModelInterpretator : IXelementModelInterpretator<BaseRssFeed>
    {
        private readonly IXElementToString xelementToStringConvertor;
        private readonly IXElementToImageProps xelementToImageProps;

        public RssFeedXElementModelInterpretator(IXElementToString xelementToStringConvertor, IXElementToImageProps xelementToImageProps)
        {
            this.xelementToStringConvertor = xelementToStringConvertor;
            this.xelementToImageProps = xelementToImageProps;
        }

        public BaseRssFeed XElementToModel(XElement x)
        {
            try
            {
                return new BaseRssFeed()
                {
                    Title = this.xelementToStringConvertor.Get("title", x),
                    Link = this.xelementToStringConvertor.Get("link", x),
                    Description = this.xelementToStringConvertor.Get("description", x),
                    PubDate = this.xelementToStringConvertor.Get("pubDate", x),
                    ImageSRC = this.xelementToImageProps.GetFrom("url", x),
                    ImageALT = this.xelementToImageProps.GetFrom("alt", x),
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException("XElement to Model Exception");
            }
        }
    }
}