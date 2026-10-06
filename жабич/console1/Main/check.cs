using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1.Main
{
    internal class check
    {
        /*
         static void Input()
        {
            List<check> checks = new List<check>();
            int nextCheckId = 1;

            check newCheck = new check();
            newCheck.id_ = nextCheckId;
            newCheck.sales_ = new List<work2_accountant_.product>();

            Console.WriteLine();
            Console.WriteLine("--- ЧЕК ---");

            int productAmount;

            while (true)
            {
                Console.Write("Введите количество товаров в чеке: ");

                if (int.TryParse(Console.ReadLine(), out productAmount)
                    && productAmount > 0)
                {
                    break;
                }

                Console.WriteLine("Количество товаров должно быть больше нуля.");
            }

            for (int i = 0; i < productAmount; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Ввод товара №" + (i + 1));

                Console.Write("Название товара: ");
                string productName = Console.ReadLine();

                Console.Write("Товарная группа: ");
                string productGroup = Console.ReadLine();

                double productPrice;

                while (true)
                {
                    Console.Write("Цена товара: ");

                    if (double.TryParse(
                        Console.ReadLine(),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out productPrice)
                        && productPrice >= 0)
                    {
                        break;
                    }

                    Console.WriteLine("--- Введите корректную цену ---");
                }

                int productCount;

                while (true)
                {
                    Console.Write("Количество товара: ");

                    if (int.TryParse(Console.ReadLine(), out productCount)
                        && productCount > 0)
                    {
                        break;
                    }

                    Console.WriteLine("--- Количество должно быть больше нуля ---");
                }

                DateTime sellDate;

                while (true)
                {
                    Console.Write("Дата продажи (дд.ММ.гггг): ");

                    if (DateTime.TryParse(
                        Console.ReadLine(),
                        out sellDate))
                    {
                        break;
                    }

                    Console.WriteLine("--- Введите корректную дату ---");
                }

                work2_accountant_.product newProduct =
                    new work2_accountant_.product();

                newProduct.name_ = productName;
                newProduct.group_ = productGroup;
                newProduct.price_ = productPrice;
                newProduct.count_ = productCount;
                newProduct.sellDate_ = sellDate;

                newCheck.sales_.Add(newProduct);

                Console.WriteLine("Товар добавлен в чек.");
            }

            checks.Add(newCheck);
            nextCheckId++;

            Console.WriteLine();
            Console.WriteLine("Чек сохранён.");
            Console.WriteLine("Номер чека: " + newCheck.id_);
            Console.WriteLine("============");
            */
    }
}
