using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieWorkshop.Services
{
    public class DataService : IDataService
    {
        private IInputService _inputService;

        private ICacheService _cacheService;

        public DataService(
            IInputService inputService,
            ICacheService cacheService
            )
        {
            this._inputService = inputService;
            this._cacheService = cacheService;
        }

        public string FizzBuzz(int number)
        {
            var result = "";

            if (number % 3 == 0 || number % 5 == 0)
            {
                if (number % 3 == 0)
                {
                    result = "Fizz";
                }

                if (number % 5 == 0)
                {
                    result += "Buzz";
                }
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }

        public string FooBarQix(int number)
        {
            number = this._inputService.GetValue(number);

            var result = this._cacheService.GetData(number);
            
            if (string.IsNullOrEmpty(result) == false)
            {
                return result;
            }

            if (number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
            {
                if (number % 3 == 0)
                {
                    result = "Foo";
                }

                if (number % 5 == 0)
                {
                    result += "Bar";
                }

                if (number % 7 == 0)
                {
                    result += "Qix";
                }

                if (number.ToString().Contains("3"))
                {
                    result += "Foo";
                }

                if (number.ToString().Contains("5"))
                {
                    result += "Bar";
                }

                if (number.ToString().Contains("7"))
                {
                    result += "Qix";
                }
            
            }
            else
            {
                result = number.ToString();
            }

            this._cacheService.SetData(number, result);

            return result;
        }
    }
}
