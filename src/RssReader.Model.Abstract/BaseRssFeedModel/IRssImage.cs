using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.Model.Abstract
{
    public interface IRssImage
    {
        string ImageSRC { get; set; }

        string ImageALT { get; set; }
    }
}