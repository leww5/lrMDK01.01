using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class HouseholdChemicals:Product
    {

        public override int CalculateDiscount()
        {
            int discount;
            switch (count_)
            {
                default:
                    discount = DefaultDiscount;
                    break;
                case int n when n >= 5 && n <= 10:
                    discount = 15;
                    break;
                case int n when n > 10:
                    discount = 25;
                    break;
            }
            return discount;
        }
    }
}
