using System;

namespace RealtorsApp.Models
{
    public class Room : RealEstate
    {
        public override int CalculateDiscount()
        {
            int discount;
            switch (Area_)
            {
                default:
                    discount = DefaultDiscount_;
                    break;
                case int n when n >= 20 && n <= 40:
                    discount = 5;
                    break;
                case int n when n < 20:
                    discount = 10;
                    break;
            }
            return discount;
        }
    }
}