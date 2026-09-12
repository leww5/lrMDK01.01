using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.functions
{
    internal class palidrom
    {
        /// Задача 6. Число-палиндром
        public static void IsPalindrome()
        {
            int number = input_natural_number.InputNaturalNumber();
            int original = number;
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            if (original == reversed)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
        }

    }
}
