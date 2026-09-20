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
            List<int> primeNumbers = new List<int>();
            for (int i = 10; i <= 2000; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                }
            }
            Console.WriteLine("Простые числа в диапазоне от 10 до 2000:");
            Console.WriteLine($"[{string.Join(", ", primeNumbers)}]");
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }
}
