using System;

namespace product
{
    public class Product
    {
        public string Name_ { get; set; }
        public int Price_ { get; set; }
        public int Stock_ { get; set; }

        public Product(string name, int price, int stock)
        {
            Name_ = name;
            Price_ = price;
            Stock_ = stock;
        }
    }
}
