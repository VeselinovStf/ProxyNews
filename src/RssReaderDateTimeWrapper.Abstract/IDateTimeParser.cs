using System;
using System.Globalization;

namespace RssReaderDateTimeWrapper.Abstract
{
    public interface IDateTimeParser
    {
        DateTime Parse(string elementDateTime, string format, CultureInfo cultureInfo);
    }
}