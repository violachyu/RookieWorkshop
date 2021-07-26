using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using StackExchange.Redis;

namespace RookieWorkshop.Services
{
    public class CacheService : ICacheService
    {
        private IDatabase _redisCache;

        public CacheService()
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            this._redisCache = redis.GetDatabase();
        }

        public string GetData(int input)
        {
            var inputString = input.ToString();
            var result = string.Empty;

            if (this._redisCache.KeyExists(inputString))
            {
                result = this._redisCache.StringGet(inputString);
            }

            return result;
        }

        public void SetData(int input, string value)
        {
            var inputString = input.ToString();

            this._redisCache.StringSet(inputString, value, TimeSpan.FromSeconds(10));
        }
    }
}
