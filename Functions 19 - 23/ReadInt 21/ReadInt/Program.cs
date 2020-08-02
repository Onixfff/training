using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            Console.Write("Введите число: ");
            while (exit)
            {
                int number;
                bool tryin = Int32.TryParse(Console.ReadLine(), out number);
                if (tryin)
                {
                    Console.WriteLine("Всё верно ваше число - " + number);
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Error ваше число не может быть сконвертировано " + number);
                }
                Console.ReadKey();
                Console.WriteLine("Введите число ещё раз");
            }
        }
    }
}
