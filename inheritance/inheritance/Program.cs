using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                CreateProduct(new Product(), "Товар без скидки", 100, 3),
                CreateProduct(new Food(), "Продукт без скидки", 80, 10),
                CreateProduct(new Food(), "Продукт со скидкой 10%", 80, 20),
                CreateProduct(new Food(), "Продукт со скидкой 30%", 80, 150),
                CreateProduct(new Food(), "Продукт со скидкой 50%", 80, 301),
                CreateProduct(new HouseholdChemicals(), "Бытовая химия без скидки", 120, 4),
                CreateProduct(new HouseholdChemicals(), "Бытовая химия со скидкой 15%", 120, 5),
                CreateProduct(new HouseholdChemicals(), "Бытовая химия со скидкой 25%", 120, 11)
            };

            foreach (Product product in products)
            {
                int discount = product.CalculateDiscount();

                Console.WriteLine(
                    $"{product.GetName()}: стоимость {product.GetPrice()}, количество {product.GetCount()}, стоимость без скидки {product.GetPrice() * product.GetCount()}, скидка {discount}%, итоговая стоимость {product.GetPrice() * product.GetCount() * (1 - (discount / 100.0))}");
            }
        }

        private static Product CreateProduct(Product product, string name, double price, int count)
        {
            product.SetName(name);
            product.SetPrice(price);
            product.SetCount(count);
            return product;
        }
    }
}
