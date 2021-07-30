using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RookieWorkshop.DataAccess;
using RookieWorkshop.Repositories;

namespace RookieWorkshop.Services
{
    public class DataService : IDataService
    {
        private IInputService _inputService;

        private ICacheService _cacheService;

        private IDataRepository _dataRepository;

        public DataService(
            IInputService inputService,
            ICacheService cacheService,
            IDataRepository dataRepository
            )
        {
            this._inputService = inputService;
            this._cacheService = cacheService;
            this._dataRepository = dataRepository;
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

            // Case010 - Insert Data into DB
            var data = new Data()
            {
                Data_Input = number,
                Data_Result = result
            };

            this._dataRepository.AddData(data);

            return result;
        }
    }
}
