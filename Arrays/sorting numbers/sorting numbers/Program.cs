using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_numbers
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int maxRandom = 10;
            int minRandom = 50;
            int[] baseArray = new int[random.Next(maxRandom, minRandom)];

            for (int i = 0; i < baseArray.Length; i++)
            {
                baseArray[i] = RandimizeNumber();
                Console.Write(baseArray[i]);
            }

            for(int i = 1; i < baseArray.Length; i++)
            {
                for(int j = 0; j < baseArray.Length; j++)
                {
                    if(baseArray[i] < baseArray[j])
                    {
                        Swap(ref baseArray[j], ref baseArray[i]);
                    }
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
            int minRandom = 1;
            int maxRandom = 10;
            return random.Next(minRandom, maxRandom);
        }
    }
}
