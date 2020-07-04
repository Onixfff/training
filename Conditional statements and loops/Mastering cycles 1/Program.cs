using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastering_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Запишите предложение:");
            int number;
            text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Сколько раз повторить этот текст");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number;  i++)
            {
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
