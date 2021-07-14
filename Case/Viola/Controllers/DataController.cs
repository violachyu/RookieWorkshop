using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RookieWorkshop.Services;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RookieWorkshop.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IDataService _dataService;

        private IInputService _inputService;

        private ICacheService _cacheService;

        private IMemoryCache _memoryCache;

        public DataController(
            IDataService dataService,
            IInputService inputService,
            ICacheService cacheService,
            IMemoryCache memoryCache
            )
        {
            this._dataService = dataService;
            this._inputService = inputService;
            this._cacheService = cacheService;
            this._memoryCache = memoryCache;
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
            var cacheResult = this._cacheService.GetData(number);

            if (cacheResult == null)
            {
                var result = this._dataService.FooBarQix(number);

                // Set CacheValue
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(5));
                this._memoryCache.Set("FooBarQix", result, cacheEntryOptions);

                return result;
            }

            return cacheResult;
        }
    }
}
