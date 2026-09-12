using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class function2_reverse
    {
        ///Задача 2. Переворот числа
        public static void ReverseNumber()
        {
            int number = input_natural_number.InputNaturalNumber();
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine($"Перевернутое число: {reversed}");
        }
    }
}
