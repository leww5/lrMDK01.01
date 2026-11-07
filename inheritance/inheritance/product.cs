using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class product
    {
        protected const int DefaultDiscount = 0;

        protected string name_; /// название
        protected double price_; /// цена за единицу
        protected int count_; /// число проданных единиц

        public product SetName(string name)
        {
            name_ = name;
            return this;    
        }
        public product SetPrice(double price)
        {
            price_ = price;
            return this;
        }
        public product SetCount(int count)
        {
            count_ = count;
            return this;
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

        public virtual double CalculateDiscount(int count)
        {
            int discount;
            switch(count)
            {
                default:
                    discount = DefaultDiscount;
                    break;
            }
            return discount;
        }
    }
}
