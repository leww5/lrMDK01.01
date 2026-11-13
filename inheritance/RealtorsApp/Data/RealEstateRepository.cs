using System;
using System.IO;

namespace RealtorsApp.Data
{
    public class RealEstateRepository
    {
        public string[] LoadFromFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}