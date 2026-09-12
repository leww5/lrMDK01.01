using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.functions
{
    internal class function4_product
    {
        ///Задача 4. Произведение цифр числа
        public static void ProductOfDigits()
        {
            int number = input_natural_number.InputNaturalNumber();
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            Console.WriteLine($"Произведение цифр числа: {product}");
        }
    }
}
