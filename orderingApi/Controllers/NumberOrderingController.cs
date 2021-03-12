using System.Collections.Generic;
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
        public ActionResult<string> Sort(string numbers)
        {
            return _service.SortListOfNumbers(numbers);
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return _service.GetLastResult();
        }
    }
}
