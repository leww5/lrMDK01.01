using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                    max = c;
            }
            else
                if (b > c)
                {
                 max = b;
                }
                else 
                 max = c;

            Console.WriteLine($"Maximum: {max}");
        }
    }
}
