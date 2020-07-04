using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string city;
            string job;
            string name;

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите город где вы живёте:");
            city = Console.ReadLine();
            Console.WriteLine("Введите ваш возрост:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу должность");
            job = Console.ReadLine();
            Console.WriteLine($"Вы {name} живёте в {city}, вам {age} года и ваша должность {job}.");
            Console.ReadKey();
        }
    }
}
