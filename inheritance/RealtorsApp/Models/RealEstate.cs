using System;

namespace RealtorsApp.Models
{
    public class RealEstate
    {
        protected string Type_;
        protected decimal Area_;
        protected string Address_;
        protected decimal Cost_;
        protected string Owner_;
        protected int DefaultDiscount_;

        public string GetEstateType()
        {
            return Type_;
        }

        public void SetEstateType(string type)
        {
            Type_ = type;
        }

        public decimal GetArea()
        {
            return Area_;
        }

        public void SetArea(decimal area)
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

        public decimal GetCost()
        {
            return Cost_;
        }

        public void SetCost(decimal cost)
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