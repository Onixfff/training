using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit_control
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            do
            {
                Console.WriteLine("Введите слово exit");
                exit = Console.ReadLine();
            } while (exit != "exit" && exit != "Exit");

            Console.WriteLine("Цикл закончился");
            Console.ReadKey();
        }
    }
}
