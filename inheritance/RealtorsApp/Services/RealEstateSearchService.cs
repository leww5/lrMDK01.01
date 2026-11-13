using System;
using System.Collections.Generic;
using RealtorsApp.Models;

namespace RealtorsApp.Services
{
    public class RealEstateSearchService
    {
        public List<RealEstate> FindByType(
            List<RealEstate> estates,
            string type)
        {
            List<RealEstate> result = new List<RealEstate>();

            foreach (RealEstate estate in estates)
            {
                if (estate.GetEstateType() == type)
                {
                    result.Add(estate);
                }
            }

            return result;
        }
    }
}