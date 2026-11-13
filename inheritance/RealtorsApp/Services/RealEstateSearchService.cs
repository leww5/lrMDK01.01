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

        public List<RealEstate> FindByArea(
            List<RealEstate> estates,
            double minArea,
            double maxArea)
        {
            List<RealEstate> result = new List<RealEstate>();

            foreach (RealEstate estate in estates)
            {
                if (estate.GetArea() >= minArea &&
                    estate.GetArea() <= maxArea)
                {
                    result.Add(estate);
                }
            }

            return result;
        }
    }
}