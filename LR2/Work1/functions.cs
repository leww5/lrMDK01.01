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

        public static int ReadNonNegativeInt(string prompt)
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
                if (v < 0)
                {
                    Console.WriteLine("Количество не может быть меньше нуля. Повторите.");
                    continue;
                }
                return v;
            }
        }

        public static int[] ReadOrder(List<product.Product> products)
        {
            int[] requested = new int[products.Count];
            while (true)
            {
                int num = ReadIntInRange("Введите номер препарата (0 — конец заказа): ", 0, products.Count);
                if (num == 0) break;
                int qty = ReadNonNegativeInt("Введите количество: ");
                requested[num - 1] += qty;
            }
            return requested;
        }
    }
}
