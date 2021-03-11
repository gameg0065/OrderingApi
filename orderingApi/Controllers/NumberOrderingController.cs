using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderingApi.Services.Interfaces;

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
        public ActionResult<List<int>> Sort(List<int> listOfNumbers)
        {
            return _service.SortListOfNumbers(listOfNumbers);
        }

        [HttpGet]
        public ActionResult<List<int>> Get()
        {
            return _service.GetLastResult();
        }
    }
}
