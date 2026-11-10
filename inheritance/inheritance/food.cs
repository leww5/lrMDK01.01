using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Food : Product
    {

        public override int CalculateDiscount()
        {
            int discount;
            switch (count_)
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
