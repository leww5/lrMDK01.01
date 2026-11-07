using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class food : product
    {

        public override double CalculateDiscount(int count)
        {
            int discount;
            switch (count)
            {
                default:
                    discount = DefaultDiscount;
                    break;
                case int n when n >= 20 && n < 150:
                    discount = 10;
                    break;
                case int n when n >= 150 && n <= 300:
                    discount = 30;
                    break;
                case int n when n > 300:
                    discount = 50;
                    break;
            }
            return discount;
        }
    }
}
