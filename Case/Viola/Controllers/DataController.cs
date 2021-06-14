using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RookieWorkshop.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RookieWorkshop.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IDataService _dataService;

        public DataController(
            IDataService dataService
            )
        {
            this._dataService = dataService;
        }

        // GET: api/<Data>
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<string> GetData()
        {
            Console.WriteLine("Hello this is rookie workshop!");
            return new string[] { "Rookie", "Workshop" };
        }

        [HttpGet("FizzBuzz/{number}")]
        [Route("1")]
        public string FizzBuzz(int number)
        {
            var result = this._dataService.FizzBuzz(number);

            return result;
        }

        // GET api/<Data>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Data>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Data>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Data>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
