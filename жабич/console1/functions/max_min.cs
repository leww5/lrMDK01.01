using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.functions
{
    internal class max_min
    {
        ///Задача 5. Максимальная и минимальная цифра числа
        public static void MaxMinDigits()
        {
            int number = input_natural_number.InputNaturalNumber();
            int max = 0;
            int min = 9;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > max)
                    max = digit;
                if (digit < min)
                    min = digit;
                number /= 10;
            }
            Console.WriteLine($"Максимальная цифра: {max}, Минимальная цифра: {min}");
        }

        ///Задача 0. Макс из 3 чисел
        public static void MaxOfThree()
        {
            Console.WriteLine("введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                    max = c;
            }
            else
                if (b > c)
                {
                    max = b;
                }
                else
                    max = c;

            Console.WriteLine($"Maximum: {max}");

        }

    }
}
