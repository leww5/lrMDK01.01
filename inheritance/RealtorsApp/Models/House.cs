using System;

namespace RealtorsApp.Models
{
    public class House : RealEstate
    {
        public override int CalculateDiscount()
        {
            return DefaultDiscount_;
        }
    }
} 