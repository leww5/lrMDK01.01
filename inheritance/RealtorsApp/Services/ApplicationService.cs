using RealtorsApp.Models;

namespace RealtorsApp.Services
{
    public class ApplicationService
    {
        public string BuildApplication(PurchaseApplication application)
        {
            string result = "";
            DiscountService discountService = new DiscountService();

            result += "ЗАЯВКА НА ПОКУПКУ\n";
            result += "-------------------------\n";

            foreach (RealEstate estate in application.GetEstates())
            {
                result +=
                    $"{estate.GetEstateType()} | Площадь: {estate.GetArea()} м² | Адрес: {estate.GetAddress()} | Стоимость: {estate.GetCost()} | Собственник: {estate.GetOwner()}\n";

                result +=
                    $"Скидка: {estate.CalculateDiscount()}% | Цена со скидкой: {discountService.GetFinalCost(estate)}\n";

                result += "\n";
            }

            result += "-------------------------\n";
            result += "Стоимость без скидки: " + application.GetTotalCost() + "\n";
            result +=
                "Итоговая стоимость: " +
                application.GetTotalCostWithDiscount() + "\n";

            return result;
        }
    }
}