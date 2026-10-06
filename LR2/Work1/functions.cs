using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class functions
    {
        public static List<product.Product> CreateAssortment()
        {
            return new List<product.Product>
            {
                new product.Product("анальгин", 35, 30),
                new product.Product("аспирин", 40, 25),
                new product.Product("йod", 120, 20),
                new product.Product("амоксициллин", 650, 12),
                new product.Product("витамины", 480, 15)
            };
        }
        public static void PrintAssortment(List<product.Product> products)
        {
            Console.WriteLine("Ассортимент:");
            for (int i = 0; i < products.Count; i++)
            {
                product.Product p = products[i];
                Console.WriteLine($"{i + 1}. {p.Name_} — {p.Price_} руб., {p.Stock_} уп.");
            }
        }

        // Подзадача: чтение номера препарата с проверкой
        public static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                if (!int.TryParse(s, out int v))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }
                if (v < min || v > max)
                {
                    Console.WriteLine($"Число вне диапазона {min}–{max}. Повторите.");
                    continue;
                }
                return v;
            }
        }
    }
}
