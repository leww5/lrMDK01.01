using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class input_natural_number
    {
        public static int InputNaturalNumber()
        {
            int number;
            do
            {
                Console.WriteLine("Введите натуральное число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Ошибка: введено не натуральное число. Попробуйте снова.");
                }
            } while (number <= 0);
            return number;
        }
    }
}
