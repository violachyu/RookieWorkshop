using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieWorkshop.Services
{
    public class DataService : IDataService
    {
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

    }
}
