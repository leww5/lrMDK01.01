using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.functions
{
    internal class prime
    {
        ///Задача 8. Проверка числа на простоту
        public static void IsPrime()
        {
            Console.WriteLine("Задача 8. Проверка числа на простоту");
            int number = input_natural_number.InputNaturalNumber();
            bool isPrime = true;
            if (number <= 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= number/2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime == true)
                Console.WriteLine("Число является простым");
            else
                Console.WriteLine("Число не является простым");
            Console.WriteLine("---");
        }
    }
}
