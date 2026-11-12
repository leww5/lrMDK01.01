using System;

namespace RealtorsApp.Models
{
    public class RealEstate
    {
        protected string type_;
        protected decimal area_;
        protected string address_;
        protected decimal cost_;
        protected string owner_;
        protected int defaultDiscount_;

        public string GetEstateType()
        {
            return type_;
        }

        public void SetEstateType(string type)
        {
            type_ = type;
        }

        public decimal GetArea()
        {
            return area_;
        }

        public void SetArea(decimal area)
        {
            area_ = area;
        }

        public string GetAddress()
        {
            return address_;
        }

        public void SetAddress(string address)
        {
            address_ = address;
        }

        public decimal GetCost()
        {
            return cost_;
        }

        public void SetCost(decimal cost)
        {
            cost_ = cost;
        }

        public string GetOwner()
        {
            return owner_;
        }

        public void SetOwner(string owner)
        {
            owner_ = owner;
        }

        public int GetDefaultDiscount()
        {
            return defaultDiscount_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{GetEstateType()} | Площадь: {GetArea()} м² | Адрес: {GetAddress()} | Стоимость: {GetCost()} | Собственник: {GetOwner()}");
        }
    }
}