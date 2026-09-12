using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class functions
    {
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




        ///Задача 1. Сумма цифр натурального числа
        public static void SumOfDigits()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Сумма цифр натурального числа: {sum}");
        }

        ///Задача 2. Переворот числа
        public static void ReverseNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine($"Перевернутое число: {reversed}");
        }

        ///Задача 3. Количество цифр в числе
        public static void CountDigits()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            Console.WriteLine($"Количество цифр в числе: {count}");
        }
    }
}
