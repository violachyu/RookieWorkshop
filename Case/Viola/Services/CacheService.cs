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

        public CacheService(
            IMemoryCache memorycache)
        {
            this._memoryCache = memorycache;
        }

        public string GetData(int input)
        {
            var result = string.Empty;
            this._memoryCache.TryGetValue("FooBarQix", out result);

            return result;
        }
    }
}
