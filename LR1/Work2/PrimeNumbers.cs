using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    internal class PrimeNumbers
    {
        public static void IsPrime()
        {
            List<int> primeNumbers = new List<int>();
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
    }
}
