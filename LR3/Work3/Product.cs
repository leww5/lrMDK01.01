using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    public enum ProductType
        {
            Analgin = 1,
            Aspirin = 2,
            Iodine = 3,
            Amoxicillin = 4,
            Vitamins = 5
        }


    internal class Product
    {
        private string name_;
        private int price_;
        private int stock_;

        public Product(string name, int price, int stock)
        {
            name_ = name;
            price_ = price;
            stock_ = stock;
        }
        public string GetName()
        {
            return name_;
        }
        public int GetPrice()
        {
            return price_;
        }
        public int GetStock()
        {
            return stock_;
        }
        public void ReduceStock(int quantity)
        {
            stock_ -= quantity;
        }
    }
}
