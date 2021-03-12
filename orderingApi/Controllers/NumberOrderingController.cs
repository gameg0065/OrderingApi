using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderingApi.Services.Interfaces;
using System;

namespace OrderingApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class NumberOrderingController : ControllerBase
    {
        private readonly ILogger<NumberOrderingController> _logger;

        private readonly IOrderNumbersService _service;

        public NumberOrderingController(ILogger<NumberOrderingController> logger, IOrderNumbersService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public IActionResult Sort(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                throw new ArgumentException("String is empty", nameof(numbers));
            }

            return Ok(_service.SortListOfNumbers(numbers));
        }

        [HttpPost("measure")]
        public IActionResult MeasureSort(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                throw new ArgumentException("String is empty", nameof(numbers));
            }

            return Ok(_service.MeasureSortListOfNumbers(numbers));
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var result = _service.GetLastResult();
            if (String.IsNullOrEmpty(result))
            {
                throw new InvalidOperationException("Return is empty");
            }
            return result;
        }
    }
}
