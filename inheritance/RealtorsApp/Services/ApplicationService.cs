using System;
using System.Text;
using RealtorsApp.Models;

namespace RealtorsApp.Services
{
    public class ApplicationService
    {
        public string BuildApplication(PurchaseApplication application)
        {
            StringBuilder result = new StringBuilder();
            DiscountService discountService = new DiscountService();

            result.AppendLine("ЗАЯВКА НА ПОКУПКУ");
            result.AppendLine("-------------------------");

            foreach (RealEstate estate in application.GetEstates())
            {
                Console.WriteLine( $"{estate.GetEstateType()} | Площадь: {estate.GetArea()} м² | Адрес: {estate.GetAddress()} | Стоимость: {estate.GetCost()} | Собственник: {estate.GetOwner()}");

                Console.WriteLine( $"Скидка: {estate.CalculateDiscount()}% | Цена со скидкой: {discountService.GetFinalCost(estate)}");

                result.AppendLine();
            }

            result.AppendLine("-------------------------");
            result.AppendLine(
                "Стоимость без скидки: " + application.GetTotalCost());
            result.AppendLine(
                "Итоговая стоимость: " +
                application.GetTotalCostWithDiscount());

            return result.ToString();
        }
    }
}