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
            Random rnd = new Random();
            int arrayLength;
            Console.WriteLine("Введите какой длинны будет массив");
            arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrayLength];
            Filling(arr, rnd);
            Output(arr,"Начальный массив");
            Shuffle(arr,rnd);
            Output(arr, "После перемешивания");
            Console.ReadKey();
        }

        static void Filling(int[]arr,Random rnd)
        {
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

        static void Shuffle(int[]arr,Random rnd)
        {
            for (int i = arr.Length - 1; i >= 1; i--) 
            {
                int randomNumber = rnd.Next(i + 1);
                var holdTheNumber = arr[randomNumber];
                arr[randomNumber] = arr[i];
                arr[i] = holdTheNumber;
            }
        }
    }
}
