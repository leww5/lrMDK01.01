using System;
using System.Collections.Generic;
using RealtorsApp.Data;
using RealtorsApp.Models;

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
            }
            while (!isValid || command != 0);
        }
    }
}