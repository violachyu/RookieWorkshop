using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RookieWorkshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Data : ControllerBase
    {
        // GET: api/<Data>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("Hello this is rookie workshop!");
            return new string[] { "Rookie", "Workshop" };
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
