using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in arrayNumbers)
            {
                Console.Write(item);
            }

            Console.Write("\nВведите сдвиг - ");
            int shift = Convert.ToInt32(Console.ReadLine());

            for(int j = shift; j > 0; j--)
            {
                int startNumberArray = arrayNumbers[0];
                
                for (int i = 0; i < arrayNumbers.Length - 1; i++)
                {
                        arrayNumbers[i] = arrayNumbers[i + 1];
                }

                arrayNumbers[arrayNumbers.Length - 1] = startNumberArray;
            }

            foreach (var item in arrayNumbers)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
