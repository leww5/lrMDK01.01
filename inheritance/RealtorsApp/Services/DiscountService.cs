using System;
using RealtorsApp.Models;

namespace RealtorsApp.Services
{
    public class DiscountService
    {
        public int GetDiscount(RealEstate estate)
        {
            return estate.CalculateDiscount();
        }
    }
}