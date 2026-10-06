using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CountLess
    {
        public static void CountLessThanMiddle()
        {
            Console.WriteLine("Введите количество элементов массива (натуральное число)");
            int n = InputNaturalNumber();
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            double average = array.Average();
        }

        public static int InputNaturalNumber()
        {
            int number;
            do
            {
                Console.Write("Введите натуральное число: ");
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
