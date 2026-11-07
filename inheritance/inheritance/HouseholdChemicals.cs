using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class HouseholdChemicals:product
    {

        public override double CalculateDiscount(int count)
        {
            int discount;
            switch (count)
            {
                default:
                    discount = DefaultDiscount;
                    break;
                case int n when n >= 5 && n < 10:
                    discount = 15;
                    break;
                case int n when n > 10:
                    discount = 25;
                    break;
            }
            return price_ * count_ * (1 - (discount / 100.0));
        }
    }
}
