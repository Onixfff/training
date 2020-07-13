using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Convert.ToChar(Console.ReadLine());

            for (int i = -1; i <= name.Length; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.WriteLine(symbol + name + symbol);
            for (int i = -1; i <= name.Length; i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}
