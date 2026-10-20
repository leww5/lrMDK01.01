using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func.PrintAssortment();

            int[] requested = Func.ReadOrder();

            if (Func.TryProcessOrder(requested, out int totalCost, out string missing))
            {
                Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            }
            else
            {
                Console.WriteLine($"Недостаточно: {missing}");
            }

            Func.PrintStocks();
        }
    }
}
