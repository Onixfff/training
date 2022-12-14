using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_shift
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nВведите сдвиг - ");
            int shift = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int startArray = 0;

            while (temp != shift)
            {
                for(int i = 0; i < arrayNumbers.Length; i++)
                {
                    if (i == 0)
                    {
                        startArray = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[i + 1];
                    }
                    else if (i == arrayNumbers.Length - 1)
                    {
                        arrayNumbers[i] = startArray;
                        temp++;
                    }
                    else
                    {
                        arrayNumbers[i] = arrayNumbers[i + 1];
                    }
                }
            }

            foreach (var item in arrayNumbers)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
