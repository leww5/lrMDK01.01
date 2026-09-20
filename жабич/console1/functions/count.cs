using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class count
    {
        ///Задача 3. Количество цифр в числе
        public static void CountDigits()
        {
            Console.WriteLine("Задача 3. Количество цифр в числе");
            int number = input_natural_number.InputNaturalNumber();
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            Console.WriteLine($"Количество цифр в числе: {count}");
            Console.WriteLine("---");
        }

    }
}
