using RssReader.JsonFormatConfigService.Dtos;
using System;

namespace RssReader.JsonFormatConfigService.Abstract
{
    public interface IJsonFormatConfig
    {
        FormatElementsDTO Get(string fileName);
    }
}