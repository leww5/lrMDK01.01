using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class sum
    {    
        ///Задача 1. Сумма цифр натурального числа
        public static void SumOfDigits()
        {
            int number = input_natural_number.InputNaturalNumber();
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Сумма цифр натурального числа: {sum}");
        }

        ///Задача 7. Сумма квадратов цифр числа
        public static void SumOfSquares()
        {
            int number = input_natural_number.InputNaturalNumber();
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            Console.WriteLine($"Сумма квадратов цифр числа: {sum}");
        }        
    }
}
