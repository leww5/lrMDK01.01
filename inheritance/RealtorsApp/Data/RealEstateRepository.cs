using System;
using System.Collections.Generic;
using System.IO;
using RealtorsApp.Models;

namespace RealtorsApp.Data
{
    public class RealEstateRepository
    {
        public List<RealEstate> LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<RealEstate> estates = new List<RealEstate>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = SplitLine(lines[i]);
                RealEstate estate = CreateRealEstate(parts);
                estates.Add(estate);
            }

            return estates;
        }

        public string[] SplitLine(string line)
        {
            return line.Split(';');
        }

        public RealEstate CreateRealEstate(string[] parts)
        {
            RealEstate estate;

            switch (parts[0])
            {
                case "дом":
                    estate = new House();
                    break;
                case "комната":
                    estate = new Room();
                    break;
                case "квартира":
                    estate = new Apartment();
                    break;
                default:
                    throw new ArgumentException("Неизвестный тип недвижимости");
            }

            estate.SetEstateType(parts[0]);
            estate.SetArea(int.Parse(parts[1]));
            estate.SetAddress(parts[2]);
            estate.SetCost(double.Parse(parts[3]));
            estate.SetOwner(parts[4]);

            return estate;
        }
    }
}