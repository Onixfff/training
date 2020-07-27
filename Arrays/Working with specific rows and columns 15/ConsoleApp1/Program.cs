using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   int sumLine = 0, sumColumn = 1;
            int line = 3 , Column = 3;
            Random rnd = new Random();
            int i, j;
            int[,] arr = new int [Column, line];
            for (i = 0; i < arr.GetLength(0);i++)
            {
                for(j = 0; j < arr.GetLength(1);j++)
                {   
                    arr[i, j] = rnd.Next(10,100);
                    Console.Write(arr[i, j]+ " | ");
                }
                Console.WriteLine();
            }

            for (i = 0; i < arr.GetLength(0); i++)
            {
                sumColumn *= arr[i, 0];
            }

            for (i = 0; i < arr.GetLength(1); i++)
            {
                sumLine += arr[1, i];
            }

            Console.WriteLine("Сумма второй строки: " + sumLine);
            Console.WriteLine("Произведение первого столбца: " + sumColumn);
            Console.ReadKey();
        }
    }
}
