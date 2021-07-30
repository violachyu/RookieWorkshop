using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RookieWorkshop.Services;
using Microsoft.Extensions.Caching.Memory;
using StackExchange.Redis;
using RookieWorkshop.DataAccess;
using RookieWorkshop.Repositories;
using RookieWorkshop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RookieWorkshop.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IDataService _dataService;

        private IDataRepository _dataRepository;

        public DataController(
            IDataService dataService,
            IDataRepository dataRepository
            )
        {
            this._dataService = dataService;
            this._dataRepository = dataRepository;
        }

        // GET: api/<Data>
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<string> GetData()
        {
            Console.WriteLine("Hello this is rookie workshop!");
            return new string[] { "Rookie", "Workshop" };
        }

        [HttpGet("GetResult/{number}")]
        [Route("1")]
        public string GetResult(int number)
        {
            var inputString = number.ToString();
            var result = this._dataService.FooBarQix(number);

            return result;
        }

        [HttpGet("GetData/{number}")]
        public DataEntity GetData(int number)
        {
            
            var result = this._dataRepository.GetData(number);

            return result;
        }


        [HttpGet("InsertData/{number}")]
        public void InsertData(int number)
        {
            this._dataService.FooBarQix(number);
        }
    }
}
