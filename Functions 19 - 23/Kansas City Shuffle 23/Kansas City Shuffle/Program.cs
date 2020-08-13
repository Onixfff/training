using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kansas_City_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите какой длинны будет массив");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Filling(arr);
            Output(arr, "Начальный массив");
            Shuffle(arr);
            Output(arr, "После перемешивания");
            Console.ReadKey();
        }

        static void Filling(int[]arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
        }

        static void Output(int[] arr, string text)
        {
            Console.Write($"{text} (");
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine(")");
        }

        static void Shuffle(int[]arr)
        {
            for (int i = arr.Length - 1; i >= 1; i--) 
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(i + 1);
                var holdTheNumber = arr[randomNumber];
                arr[randomNumber] = arr[i];
                arr[i] = holdTheNumber;
            }
        }
    }
}
