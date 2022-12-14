using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_numbers
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] baseArray = new int[rnd.Next(10, 50)];

            for (int i = 0; i < baseArray.Length; i++)
            {
                baseArray[i] = RandimizeNumber();
                Console.Write(baseArray[i]);
            }

            for (int i = 1; i < baseArray.Length; i++)
            {
                int key = baseArray[i];
                int j = i;
                while ((j >= 1) && (baseArray[j - 1] > key))
                {
                    Swap(ref baseArray[j - 1], ref baseArray[j]);
                    j--;
                }
            }

            Console.WriteLine();

            foreach (var item in baseArray)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }

        static void Swap(ref int numberOne, ref int NumberTwo)
        {
            int temp = numberOne;
            numberOne = NumberTwo;
            NumberTwo = temp;
        }

        static int RandimizeNumber()
        {
            return rnd.Next(1, 10);
        }
    }
}
