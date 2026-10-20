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

    }
}
