using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.lab1
{
    internal class PrimeNumber
    {
        /// Задача 2: отобрать все простые числа в диапазоне от 10 до 2000 и вывести в формате [a1, a2, ...]
        public static void IsPrime()
        {
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
