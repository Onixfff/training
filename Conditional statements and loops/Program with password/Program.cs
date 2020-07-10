using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_with_password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            string userInput;

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"Введите пороль.Попыток осталось {i}");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.WriteLine("Секретное сообщение!");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Неправельно набранн пороль");
                }
            }
            Console.ReadKey();
        }
    }
}
