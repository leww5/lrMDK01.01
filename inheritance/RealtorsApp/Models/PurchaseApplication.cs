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
    }
}