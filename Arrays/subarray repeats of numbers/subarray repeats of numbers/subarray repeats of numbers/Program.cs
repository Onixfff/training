using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subarray_repeats_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] baseArray = new int[30] { 0, 0, 0, 0, 0, 0, 0, 8, 9, 10, 11, 12, 5, 5, 5, 5, 5, 18, 19, 20, 21, 22, 6, 6, 6, 6, 6, 6, 6, 30 };
            int repeat = 0;
            int maxNumberRepeat = 0;
            int maxRepeat = 0;
            int number = baseArray[0];

            for(int i = 0; i < baseArray.Length; i++)
            {
                Console.Write(baseArray[i]);
                if (number != baseArray[i])
                {
                    if (repeat > maxRepeat)
                    {
                        maxNumberRepeat = number;
                        maxRepeat = repeat;
                    }
                    number = baseArray[i];
                    repeat = 1;
                }
                else
                {
                    if (number == baseArray[i])
                    {
                        repeat++;
                    }
                }
            }

            Console.Write($" - Число {maxNumberRepeat} повторяется подрят - {maxRepeat} раз ");
            Console.ReadKey();
        }
    }
}
