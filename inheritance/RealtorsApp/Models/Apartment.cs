using System;

namespace RealtorsApp.Models
{
    public class Apartment : RealEstate
    {
        public override int CalculateDiscount()
        {
            return DefaultDiscount_;
        }
    }
}