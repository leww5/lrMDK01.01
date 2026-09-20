using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.lab1
{
    internal class LessThatMiddle
    {
        ///Задача 1. С клавиатуры ввести массив из n целых чисел. Определить количество элементов, меньших среднего значения массива.
        public static void CountLessThanMiddle()
        {
            Console.WriteLine("Введите количество элементов массива (натуральное число)");
            int n = input_natural_number.InputNaturalNumber();
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            double average = array.Average();
            int count = array.Count(x => x < average);
            Console.WriteLine($"Количество элементов, меньших среднего значения массива ({average}): {count}");
            Console.WriteLine("---");
        }
    }
}
