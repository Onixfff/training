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
            int waitingTime1Person = 10;
            int waitTime;
            int hout;
            int min;
            Console.WriteLine("Сколько в очереди человек: ");
            queue = Convert.ToInt32(Console.ReadLine());
            waitTime = queue * waitingTime1Person;
            hout = waitTime / 60;//Время ожидания в часах. для вывода
            min =  queue * waitingTime1Person % 60;//Время ожидания в мин. для вывода
            Console.WriteLine($"Вы должны отстоять в очереди {hout} часов и {min} минут.");
            Console.ReadKey();
        }
    }
}
