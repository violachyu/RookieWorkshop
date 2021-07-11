using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace RookieWorkshop.Services
{
    public class CacheService : ICacheService
    {
        private IMemoryCache _memoryCache;
        private IDataService _dataService;

        public CacheService(
            IMemoryCache memorycache,
            IDataService dataService)
        {
            this._memoryCache = memorycache;
            this._dataService = dataService;
        }

        public string GetData(int input)
        {
            var result = string.Empty;
            bool cacheValue = this._memoryCache.TryGetValue("FooBarQix", out result);

            if (cacheValue == false)
            {
                // Get FooBarQix Data
                result = this._dataService.FooBarQix(input);
                
                // Set CacheValue
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(5));
                this._memoryCache.Set("FooBarQix", result, cacheEntryOptions);
            }
            return result;
        }
    }
}
