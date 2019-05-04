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
        private readonly IXelementToDateTime xElementToDateTime;

        public RssFeedXElementModelInterpretator(
            IXElementToString xelementToStringConvertor,
            IXElementToImageProps xelementToImageProps,
            IXelementToDateTime xElementToDateTime)
        {
            this.xelementToStringConvertor = xelementToStringConvertor;
            this.xelementToImageProps = xelementToImageProps;
            this.xElementToDateTime = xElementToDateTime;
        }

        public BaseRssFeed XElementToModel(XElement x)
        {
            try
            {
                return new BaseRssFeed()
                {
                    // TODO: link propertyes names for json config , so property name can be changed based pn user requirements
                    Title = this.xelementToStringConvertor.Get("title", x),
                    Link = this.xelementToStringConvertor.Get("link", x),
                    Description = this.xelementToStringConvertor.Get("description", x),
                    PubDate = this.xElementToDateTime.Get("pubDate", x),
                    ImageSRC = this.xelementToImageProps.GetFrom("src", x),
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