using console1.functions;
using console1.work1;
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
            /*
            lab1.LessThatMiddle.CountLessThanMiddle();
            lab1.PrimeNumber.IsPrime();
            sum.SumOfDigits();
            reverse.ReverseNumber();
            count.CountDigits();
            product.ProductOfDigits();
            max_min.MaxMinDigits();
            palidrom.IsPalindrome();
            sum.SumOfSquares();
            prime.IsPrime();
            min_max_guests_in_cofe.quest2();
             */

            /// ---

            pc pc1 = new pc();
            pc1.name_ = "Первый на Интел";
            pc1.work_ = false;
            objects__objects.PrintPc(pc1.name_, pc1.work_);
            Console.WriteLine("---");
            pc pc2 = new pc() { name_ = "Первый на АМД", work_ = true };
            objects__objects.PrintPc(pc2.name_, pc2.work_);
            Console.WriteLine("---");

            pc pc3 = new pc() { name_ = "Второй на АМД", work_ = false };
            pc pc4 = new pc() { name_ = "Третий на АМД", work_ = true };
            pc pc5 = new pc() { name_ = "Второй на Интел", work_ = true };

            List<pc> pcs = new List<pc> { pc1, pc2, pc3, pc4, pc5 };

            Console.WriteLine("---");


        }
    }
}
