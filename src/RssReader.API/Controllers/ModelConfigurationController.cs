using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelConfigurationController : ControllerBase
    {
        public IActionResult Update(string propName)
        {
            return Ok("change prop");
        }

        public IActionResult Insert(string propName)
        {
            return Ok("add prop");
        }

        public IActionResult Remove(string propName)
        {
            return Ok("add prop");
        }
    }
}