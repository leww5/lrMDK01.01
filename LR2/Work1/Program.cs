using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product.Product> products = functions.CreateAssortment();
            functions.PrintAssortment(products);

            int[] requested = functions.ReadOrder(products);
        }
    }
}
