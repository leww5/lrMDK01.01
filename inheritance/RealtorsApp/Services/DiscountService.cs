using System;
using RealtorsApp.Models;

namespace RealtorsApp.Services
{
    public class DiscountService
    {
        public double GetFinalCost(RealEstate estate)
        {
            double cost = estate.GetCost();
            int discount = estate.CalculateDiscount();

            return cost - cost * discount / 100;
        }
    }
}