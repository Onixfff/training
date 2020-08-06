using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kansas_City_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Filling(arr);
            Output(arr);
            Shuffle(arr);
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

        static void Output(int[] arr)
        {
            Console.Write("Начальный массив (");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,2}", arr[i]);
            }
            Console.WriteLine(")");
        }

        static void Shuffle(int[]arr)
        {
            Console.Write("После перемешивания (");

            

            Console.Write(")");
        }
    }
}
