using Microsoft.AspNetCore.Mvc;
using RssReader.JsonFormatConfigService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssReader.API.Controllers
{
    /// <summary>
    /// Managing Rss Formatings
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FormatConfigurationController : ControllerBase
    {
        private readonly IJsonFormatConfig jsonFormatConfigService;

        public FormatConfigurationController(IJsonFormatConfig jsonFormatConfigService)
        {
            this.jsonFormatConfigService = jsonFormatConfigService;
        }

        /// <summary>
        /// Get All Formating Parameters
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var fromJsonConfig = this.jsonFormatConfigService.Get("formatingElementsConfig.json");

            return Ok(fromJsonConfig);
        }
    }
}