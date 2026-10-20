using System;
using System.Collections.Generic;

namespace Work1
{
    internal class functions
    {
        public static List<product.Product> CreateAssortment()
        {
            return new List<product.Product>
            {
                new product.Product { Name_ = "анальгин", Price_ = 35, Stock_ = 30 },
                new product.Product { Name_ = "аспирин", Price_ = 40, Stock_ = 25 },
                new product.Product { Name_ = "йод", Price_ = 120, Stock_ = 20 },
                new product.Product { Name_ = "амоксициллин", Price_ = 650, Stock_ = 12 },
                new product.Product { Name_ = "витамины", Price_ = 480, Stock_ = 15 }
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


    }
}
