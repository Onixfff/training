using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findingTheMinimumDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int statickNumber = 2;
            int minRandom = 0;
            int maxRandom = 100;
            int randomNumber = random.Next(minRandom, maxRandom);
            int sum = 0;

            for(int degree = 0; sum < randomNumber; degree++)
            {
                sum = (int)Math.Pow(statickNumber, degree);
            }

            Console.ReadKey();
        }
    }
}
