using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int queue;
            int time = 10;
            int wait;
            int hout;
            int min;
            Console.WriteLine("Сколько в очереди человек: ");
            queue = Convert.ToInt32(Console.ReadLine());
            wait = queue * time;
            hout = wait / 60;
            min =  queue * 10 % 60;
            Console.WriteLine($"Вы должны отстоять в очереди {hout} часов и {min} минут.");
            //Console.WriteLine($"Вы должны отстоять в очереди {wait} часа и {wait} минут.");
            Console.ReadKey();
        }
    }
}
