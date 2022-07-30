using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking_the_closure_of_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDepth = 0;
            int depth = 0;
            string bracket = ")(())()";

            foreach (var bracketChar in bracket)
            {
                if (bracketChar == '(')
                {
                    depth++;
                }
                else if (depth == 0 && bracketChar == ')')
                {
                    Console.WriteLine("Скобочное выражение не является коректным");
                    break;
                }
                else if (depth != 0 && bracketChar == ')')
                {
                    if (maxDepth < depth)
                    {
                        maxDepth = depth;
                    }
                    depth --;
                }
            }
            Console.WriteLine($"Максимальная глубина = " + maxDepth);
            Console.ReadKey();
        }
    }
}
