using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array_advanced___26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            bool addedNumber = true;
            int number;
            int sum;

            while (addedNumber)
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());

                numbers.Add(number);

                Console.WriteLine("Вывечти sum всех ваших чисел?" +
                    "\nда или нет");

                if (Console.ReadLine().ToLower() == "да")
                {
                    sum = 0;

                    Console.Clear();

                    foreach (var numberArray in numbers)
                    {
                        sum += numberArray;
                    }

                    Console.WriteLine("Сумма всех чисел: " + sum + 
                        "\nПродолжить ?" +
                        "\nда или нет");

                    if (Console.ReadLine().ToLower() == "нет")
                    {
                        addedNumber = false;
                    }

                    Console.Clear();
                }
            }
        }
    }
}
