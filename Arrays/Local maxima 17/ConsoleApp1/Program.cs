using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[30];

            for (int i = 0; i < numbers.Length; i++)
            {   
                numbers[i] = rnd.Next(10,100);
            }

            if(numbers[0] > numbers[1])
            {
                Console.WriteLine(numbers[0]);
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if(numbers[i] > numbers [i + 1] && numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            if(numbers[numbers.Length-1] > numbers[numbers.Length -2])
            {
                Console.WriteLine(+ numbers[numbers.Length - 1]);
            }

            Console.ReadKey();
        }
    }
}