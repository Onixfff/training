using System;

namespace Basics_of_programming__7._1
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "Антонин";
            string surname = "Данилка";

            Console.WriteLine($"Name - {name}\nSurname - {surname}\n");

            string variable = name;
            name = surname;
            surname = variable;

            Console.WriteLine($"Name - {name}\nSurname - {surname}\n");
            Console.ReadKey(true);
        }
    }
}
