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
                new Product()
                    .SetName("Товар без скидки")
                    .SetPrice(100)
                    .SetCount(3),

                new Food()
                    .SetName("Продукт без скидки")
                    .SetPrice(80)
                    .SetCount(10),

                new Food()
                    .SetName("Продукт со скидкой 10%")
                    .SetPrice(80)
                    .SetCount(20),

                new Food()
                    .SetName("Продукт со скидкой 30%")
                    .SetPrice(80)
                    .SetCount(150),

                new Food()
                    .SetName("Продукт со скидкой 50%")
                    .SetPrice(80)
                    .SetCount(301),

                new HouseholdChemicals()
                    .SetName("Бытовая химия без скидки")
                    .SetPrice(120)
                    .SetCount(4),

                new HouseholdChemicals()
                    .SetName("Бытовая химия со скидкой 15%")
                    .SetPrice(120)
                    .SetCount(5),

                new HouseholdChemicals()
                    .SetName("Бытовая химия со скидкой 25%")
                    .SetPrice(120)
                    .SetCount(11)
            };

            foreach (Product product in products)
            {
                int discount = product.CalculateDiscount();

                Console.WriteLine(
                    $"{product.GetName()}: стоимость {product.GetPrice()}, количество {product.GetCount()}, стоимость без скидки {product.GetPrice() * product.GetCount()}, скидка {discount}%, итоговая стоимость {product.GetPrice() * product.GetCount() * (1 - (discount / 100.0))}");
            }
        }
    }
}
