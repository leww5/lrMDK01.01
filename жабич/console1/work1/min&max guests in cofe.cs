using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace console1.work1
{
    internal class min_max_guests_in_cofe
    {
        /// Задача 2. нахождение и вывод периоды(первое значение списка guests) с наибольшим и наименьшим количеством посетителей(второе значение списка guests)
        public static void quest2()
        {
            Dictionary<string, int> guests = new Dictionary<string, int>()
            {
                {"8-9",12},
                {"9-10",8},
                {"10-11",4},
                {"11-12",18},
                {"12-13",2},
                {"13-14",12},
                {"14-15",7},
                {"16-17",18},
                {"17-18",2},
                {"19-20",13},
            };

            int max = guests.Values.Max();
            int min = guests.Values.Min();
            List<string> maxPeriods = new List<string>();
            List<string> minPeriods = new List<string>();

            foreach (KeyValuePair<string, int> person in guests)
            {
                if (max == person.Value)
                {
                    maxPeriods.Add(person.Key);
                }

                if (min == person.Value)
                {
                    minPeriods.Add(person.Key);
                }

                Console.WriteLine($"час: {person.Key} посетители: {person.Value}");
            }
            Console.WriteLine("Период(ы) с максимальным значением посетителей:");
            foreach (string item in maxPeriods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Период(ы) с минимальным значением посетителей:");
            foreach (string item in minPeriods)
            {
                Console.WriteLine(item);
            }

        }
    }
}
