using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieWorkshop.Services
{
    public class InputService : IInputService
    {
        private Random random = new Random();

        public int GetValue(int max)
        {
            int result = this.random.Next(max + 1);

            return result;
        }
    }
}
