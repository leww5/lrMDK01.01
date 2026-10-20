using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class Func
    {
        private static Work3.Product analgin = new Work3.Product("анальгин", 35, 30);
        private static Work3.Product aspirin = new Work3.Product("аспирин", 40, 25);
        private static Work3.Product iodine = new Work3.Product("йод", 120, 20);
        private static Work3.Product amoxicillin = new Work3.Product("амоксициллин", 650, 12);
        private static Work3.Product vitamins = new Work3.Product("витамины", 480, 15);

        private static Work3.Product GetProduct(Work3.ProductType type)
        {
            switch (type)
            {
                case Work3.ProductType.Analgin: return analgin;
                case Work3.ProductType.Aspirin: return aspirin;
                case Work3.ProductType.Iodine: return iodine;
                case Work3.ProductType.Amoxicillin: return amoxicillin;
                case Work3.ProductType.Vitamins: return vitamins;
                default: throw new ArgumentException("Неизвестный препарат.");
            }
        }

        public static void PrintAssortment()
        {
            Console.WriteLine("Ассортимент:");
            for (int i = 1; i <= (int)Work3.ProductType.Vitamins; i++)
            {
                Work3.Product p = GetProduct((Work3.ProductType)i);
                Console.WriteLine($"{i}. {p.GetName()} — {p.GetPrice()} руб., {p.GetStock()} уп.");
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
        public static int[] ReadOrder()
        {
            int productCount = (int)product.ProductType.Vitamins;
            int[] requested = new int[productCount];
            while (true)
            {
                int num = ReadIntInRange("Введите номер препарата (0 — конец заказа): ", 0, productCount);
                if (num == 0) break;
                int qty = ReadNonNegativeInt("Введите количество: ");
                requested[num - 1] += qty;
            }
            return requested;
        }
        public static bool TryProcessOrder(int[] requested, out int totalCost, out string missingProductName)
        {
            totalCost = 0;
            missingProductName = null;
            for (int i = 1; i <= (int)Work3.ProductType.Vitamins; i++)
            {
                Work3.Product p = GetProduct((Work3.ProductType)i);
                if (requested[i - 1] > p.GetStock())
                {
                    missingProductName = p.GetName();
                    return false;
                }
            }
            for (int i = 1; i <= (int)Work3.ProductType.Vitamins; i++)
            {
                Work3.Product p = GetProduct((Work3.ProductType)i);
                p.ReduceStock(requested[i - 1]);
                totalCost += requested[i - 1] * p.GetPrice();
            }
            return true;
        }
        public static void PrintStocks()
        {
            Console.Write("Остатки упаковок: ");
            for (int i = 1; i <= (int)Work3.ProductType.Vitamins; i++)
            {
                Work3.Product p = GetProduct((Work3.ProductType)i);
                Console.Write(p.GetName() + " " + p.GetStock());
                if (i < (int)Work3.ProductType.Vitamins) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
    }
}
