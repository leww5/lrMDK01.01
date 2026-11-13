using System;
using System.Collections.Generic;
using RealtorsApp.Data;
using RealtorsApp.Models;
using RealtorsApp.Services;

namespace RealtorsApp.ConsoleUI
{
    public class ConsoleMenu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("1. Показать все объекты");
            Console.WriteLine("2. Найти объект");
            Console.WriteLine("3. Создать заявку");
            Console.WriteLine("0. Выход");
        }

        public void ShowEstates(List<RealEstate> estates)
        {
            for (int i = 0; i < estates.Count; i++)
            {
                Console.Write((i + 1) + ". ");
                estates[i].PrintInfo();
            }
        }

        public List<RealEstate> LoadEstates(string filePath)
        {
            RealEstateRepository repository =
                new RealEstateRepository();

            return repository.LoadFromFile(filePath);
        }

        public void SearchByType(List<RealEstate> estates)
        {
            Console.Write("Введите тип недвижимости: ");
            string type = Console.ReadLine();

            RealEstateSearchService searchService =
                new RealEstateSearchService();

            List<RealEstate> result =
                searchService.FindByType(estates, type);

            if (result.Count == 0)
            {
                Console.WriteLine("Объекты не найдены.");
            }
            else
            {
                ShowEstates(result);
            }
        }

        public void SearchByArea(List<RealEstate> estates)
        {
            double minArea;
            double maxArea;

            Console.Write("Введите минимальную площадь: ");
            bool minIsValid = double.TryParse(
                Console.ReadLine(),
                out minArea);

            Console.Write("Введите максимальную площадь: ");
            bool maxIsValid = double.TryParse(
                Console.ReadLine(),
                out maxArea);

            if (!minIsValid || !maxIsValid || minArea > maxArea)
            {
                Console.WriteLine("Введите корректный диапазон площади.");
                return;
            }

            RealEstateSearchService searchService =
                new RealEstateSearchService();

            List<RealEstate> result =
                searchService.FindByArea(estates, minArea, maxArea);

            if (result.Count == 0)
            {
                Console.WriteLine("Объекты не найдены.");
            }
            else
            {
                ShowEstates(result);
            }
        }

        public void Run()
        {
            List<RealEstate> estates = LoadEstates("realestate.csv");
            int command;
            bool isValid;

            do
            {
                ShowMainMenu();
                isValid = int.TryParse(Console.ReadLine(), out command);

                if (!isValid || command < 0 || command > 3)
                {
                    Console.WriteLine("Введите номер пункта от 0 до 3.");
                }
                else if (command == 1)
                {
                    ShowEstates(estates);
                }
                else if (command == 2)
                {
                    SearchByType(estates);
                }
            }
            while (!isValid || command != 0);
        }
    }
}