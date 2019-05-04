using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RssReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        public IActionResult ViewAll()
        {
            return Ok("value all");
        }

        public IActionResult Get(string confName)
        {
            return Ok("value single");
        }
    }
}