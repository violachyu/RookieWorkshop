using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RookieWorkshop.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET: api/<Data>
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<string> GetData()
        {
            Console.WriteLine("Hello this is rookie workshop!");
            return new string[] { "Rookie", "Workshop" };
        }

        [HttpGet("FizzBuzz/{end}")]
        [Route("1")]
        public IEnumerable<string> FizzBuzz(int end)
        {
            var numberList = Enumerable.Range(1, end).ToList();
            var result = new List<string>();

            foreach(var number in numberList)
            {
                string item = "";
                
                if (number % 3 == 0 || number % 5 == 0)
                {
                    if (number % 3 == 0)
                    {
                        item = "Fizz";
                    }

                    if (number % 5 == 0)
                    {
                        item += "Buzz";
                    }
                }
                else
                {
                    item = number.ToString();
                }

                result.Add(item);
            }

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
