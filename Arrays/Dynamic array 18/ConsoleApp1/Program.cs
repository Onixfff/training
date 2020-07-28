using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string usingInputString;
            int usingInput, sum = 0;

            int[] numbers = new int[0];

            while(true)
            {
                Console.WriteLine("Введите число");
                usingInput = Convert.ToInt32(Console.ReadLine());                
                int[] newNumbers = new int [numbers.Length + 1];
                for (int i = 0; i < numbers.Length; i++)
                {
                    newNumbers[i] = numbers[i];
                }
                newNumbers[newNumbers.Length - 1] = usingInput;
                numbers = newNumbers;

                Console.WriteLine("Введите sum если надо подвести итог");
                usingInputString = Console.ReadLine();
                
                if (usingInputString == "sum")
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers [i];
                    }
                    Console.WriteLine();
                    Console.WriteLine("Сумма: " + sum +"\n\nВведите любой символ для продолжения или exit для выхода");
                    sum = 0;
                    usingInputString = Console.ReadLine();
                }
                if (usingInputString == "exit")
                {
                    break;
                }
            }
        }
    }
}
