using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int firstMultiple = 3;
            int secondMultiple = 5;
            int minRandom = 0;
            int maxRandom = 100;
            int randomNumber = random.Next(minRandom, maxRandom);
            int sum = 0;

            for(int reducedNumber = randomNumber; reducedNumber > 0; reducedNumber--)
            {
                if (reducedNumber % firstMultiple == 0 || reducedNumber % secondMultiple == 0)
                {
                    sum = sum + reducedNumber;
                }
            }

            Console.WriteLine($"{randomNumber}\n{sum}");
            Console.ReadKey();
        }
    }
}
