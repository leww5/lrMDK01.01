using System;
using System.Collections.Generic;

namespace RealtorsApp.Models
{
    public class PurchaseApplication
    {
        private List<RealEstate> Estates =
            new List<RealEstate>();

        public void AddEstate(RealEstate estate)
        {
            if (estate != null)
            {
                Estates.Add(estate);
            }
        }

        public void RemoveEstate(RealEstate estate)
        {
            Estates.Remove(estate);
        }

        public List<RealEstate> GetEstates()
        {
            return Estates;
        }

        public int GetEstateCount()
        {
            return Estates.Count;
        }

        public double GetTotalCost()
        {
            double totalCost = 0;

            foreach (RealEstate estate in Estates)
            {
                totalCost += estate.GetCost();
            }

            return totalCost;
        }
    }
}