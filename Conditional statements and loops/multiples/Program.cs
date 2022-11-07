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
            long result = 0;
            int min = 7;
            int max = 27;
            int maxNaturalNumber = 9;

            for (int firstDigit = 1; firstDigit < maxNaturalNumber; ++firstDigit)
            {
                for(int secondDigit = 0; secondDigit < maxNaturalNumber; ++secondDigit)
                {
                    int sumDemoResult = firstDigit + secondDigit;
                    for(int thirdDigit = 0; thirdDigit < maxNaturalNumber; ++thirdDigit)
                    {
                        int sum = sumDemoResult + thirdDigit;
                        if (min <= sum && sum <= max)
                            result++;
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
