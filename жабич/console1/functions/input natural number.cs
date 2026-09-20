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
            do { Console.Write("Введите натуральное число: "); 
                string input = Console.ReadLine();
                if (!int.TryParse(input, out number)) 
                {
                    Console.WriteLine("Ошибка: введено не число. Попробуйте снова."); continue; 
                } 
                if (number <= 0) 
                {
                    Console.WriteLine("Ошибка: введено не натуральное число. Попробуйте снова."); 
                } 
            } while (number <= 0);
            return number;
        }
    }
}
