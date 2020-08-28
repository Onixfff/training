using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dynamic_array_advanced___26
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            int number;
            int sum;

            bool addNumber = true;
            bool exit = false;

            ConsoleColor defaultColor = Console.ForegroundColor;

            List<int> numbers = new List<int>();

            while (exit == false) {
                do
                {
                    Console.WriteLine("Введите целое число или sum");
                    userInput = Console.ReadLine().ToLower();
                    addNumber = int.TryParse(userInput, out number);
                    if (addNumber == false && userInput != "sum")
                    {
                        Console.Clear();
                        Error("Вы ошиблись при вводе. Попробуйте ещё раз", ConsoleColor.Red, defaultColor);

                    }
                } while (addNumber == false && userInput != "sum");

                numbers.Add(number);

                if (userInput == "sum")
                {
                    Sum(out sum, numbers);

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine($"Результат: {sum}" +
                        $"\nВведите Exit если хотете завершить программу " +
                        $"\n\t\t\tили" +
                        $"\nsum ещё раз, чтобы начать программу занова.");

                    Console.ForegroundColor = defaultColor;

                    userInput = (Console.ReadLine().ToLower());

                    if (userInput == "exit")
                    {
                        exit = true;
                    }
                    else if(userInput == "sum")
                    {
                        sum = 0;
                    }

                    Console.Clear();
                }
            }
        }

        static void Sum(out int sum, List<int> numbers) 
        {
            sum = 0;
            foreach (var result in numbers)
            {
                sum += result;
            }
        }

        static void Error(string text, ConsoleColor color, ConsoleColor defaultColor)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine($"{text}");
            Console.ForegroundColor = defaultColor;
        }
    }
}
