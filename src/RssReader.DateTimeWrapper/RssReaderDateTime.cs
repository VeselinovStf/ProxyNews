using RssReaderDateTimeWrapper.Abstract;
using System;
using System.Globalization;

namespace RssReader.DateTimeWrapper
{
    public class RssReaderDateTime : IDateTimeParser
    {
        public DateTime Parse(string elementDateTime, string format, CultureInfo cultureInfo)
        {
            return DateTime.ParseExact(elementDateTime, format, cultureInfo);
        }
    }
}