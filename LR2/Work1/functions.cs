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
    }
}
