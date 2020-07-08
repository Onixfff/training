using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0; 
            for(int i = 0; i <= 13; i++ )
            {
                number += 7;
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
