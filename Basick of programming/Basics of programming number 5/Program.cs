﻿using System;
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
            int waitingTimePerson = 10;
            int waitTime;
            int hout;
            int min;
            Console.WriteLine("Сколько в очереди человек: ");
            queue = Convert.ToInt32(Console.ReadLine());
            waitTime = queue * waitingTimePerson;
            hout = waitTime / 60;
            min =  queue * waitingTimePerson % 60;
            Console.WriteLine($"Вы должны отстоять в очереди {hout} часов и {min} минут до вашего приёма.");
            Console.ReadKey();
        }
    }
}
