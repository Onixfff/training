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
            
            int randomNumber = random.Next(0,100);
            int reducedNumber = randomNumber;
            int sum = 0;

            while (reducedNumber > 0)
            {
                if (reducedNumber % 3 == 0 || reducedNumber % 5 == 0)
                {
                    sum = sum + reducedNumber;
                }
                reducedNumber--;
            }

            Console.WriteLine($"{randomNumber}\n{sum}");
            Console.ReadKey();
        }
    }
}
