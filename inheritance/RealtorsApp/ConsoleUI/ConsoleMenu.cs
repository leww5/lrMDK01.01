using System;

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
    }
}