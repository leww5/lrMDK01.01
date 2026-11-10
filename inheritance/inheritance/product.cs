using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Product
    {
        protected const int DefaultDiscount = 0;

        protected string name_; /// название
        protected double price_; /// цена за единицу
        protected int count_; /// число проданных единиц

        public void SetName(string name)
        {
            name_ = name;
        }
        public void SetPrice(double price)
        {
            price_ = price;
        }
        public void SetCount(int count)
        {
            count_ = count;
        }

        public string GetName()
        {
            return name_;
        }
        public double GetPrice()
        {
            return price_;
        }
        public int GetCount()
        {
            return count_;
        }

        public virtual int CalculateDiscount()
        {
            return DefaultDiscount;
        }
    }
}
