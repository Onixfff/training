using System;

namespace Basics_of_programming__7._1
{
    internal class Program
    {
        public static string name = "Валантос";
        public static string surname = "Danilka";
        static void Main(string[] args)
        {
            OutPutInfo();
            Swaps(ref name, ref surname);
            OutPutInfo();
            Console.ReadKey(true);
        }

        public static void Swaps(ref string name, ref string surname)
        {
            string variable = name;
            name = surname;
            surname = variable;
        }

        public static void OutPutInfo()
        {
            Console.WriteLine($"Name - {name}\nSurname - {surname}\n");
        }
    }
}
