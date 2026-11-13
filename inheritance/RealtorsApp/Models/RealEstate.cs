using System;

namespace RealtorsApp.Models
{
    public class RealEstate
    {
        protected string Type_;
        protected int Area_;
        protected string Address_;
        protected double Cost_;
        protected string Owner_;
        protected int DefaultDiscount_ = 0;

        public string GetEstateType()
        {
            return Type_;
        }

        public void SetEstateType(string type)
        {
            Type_ = type;
        }

        public double GetArea()
        {
            return Area_;
        }

        public void SetArea(int area)
        {
            Area_ = area;
        }

        public string GetAddress()
        {
            return Address_;
        }

        public void SetAddress(string address)
        {
            Address_ = address;
        }

        public double GetCost()
        {
            return Cost_;
        }

        public void SetCost(double cost)
        {
            Cost_ = cost;
        }

        public string GetOwner()
        {
            return Owner_;
        }

        public void SetOwner(string owner)
        {
            Owner_ = owner;
        }

        public int GetDefaultDiscount()
        {
            return DefaultDiscount_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{GetEstateType()} | Площадь: {GetArea()} м² | Адрес: {GetAddress()} | Стоимость: {GetCost()} | Собственник: {GetOwner()}");
        }

        public virtual int CalculateDiscount()
        {
            return DefaultDiscount_;
        }
    }
}