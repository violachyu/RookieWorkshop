using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieWorkshop.Services
{
    public class DataService : IDataService
    {
        private IInputService _inputService;

        public DataService(IInputService inputService)
        {
            this._inputService = inputService;
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

            var result = string.Empty;

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

            return result;
        }
    }
}
