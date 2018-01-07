namespace Api.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("GET api/values");
            return new[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogInformation($"GET api/values/{id}");
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            _logger.LogInformation($"POST api/values {value}");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            _logger.LogInformation($"PUT api/values/{id} {value}");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogInformation($"DELETE api/values/{id}");
        }
    }
}
