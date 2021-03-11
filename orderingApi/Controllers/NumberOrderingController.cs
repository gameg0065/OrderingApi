using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace orderingApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class NumberOrderingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NumberOrderingController> _logger;

        public NumberOrderingController(ILogger<NumberOrderingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<List<int>> Sort(List<int> listOfNumbers)
        {
            listOfNumbers.ForEach(x => Console.WriteLine(x));
            var temp = new List<int>(new int[] { 1, 2, 3 });
            return temp;
        }

        [HttpGet]
        public ActionResult<List<int>> Get()
        {
            var temp = new List<int>(new int[] { 6, 5, 4 });
            return temp;
        }
    }
}
