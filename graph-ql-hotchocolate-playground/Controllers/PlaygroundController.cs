using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bnaya.Samples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaygroundController : ControllerBase
    {
        private readonly ILogger<PlaygroundController> _logger;

        public PlaygroundController(ILogger<PlaygroundController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}
