using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int furstElement = 1;
            int secondElement = 2;
            List<int> threeDigitNumbers = new List<int>();

            for (n = 1; n <= 27; n++)
            {
                Console.Write(n + " - ");
                for (int i = 100; i < 1000; i++)
                {
                    if(i % n == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
