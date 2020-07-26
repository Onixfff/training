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
            int[,] arr = {
                {1,3,6},
                {4,7,8},
                {2,4,1}
            };
            for (int i = 0; i < arr.GetLength(0);i++)
            {   
                if (i == 1)
                {
                   for (int j = 0; j < arr.GetLength(1); j++)
                   {
                        sumLine += arr[i,j];
                   }
                }
                for(int j = 0; j < arr.GetLength(1);j++)
                {   
                    if (j == 0)
                    {
                        sumColumn *= arr[i,j];
                    }
                    Console.Write(arr[i, j]+ " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма 2 строки: " + sumLine);
            Console.WriteLine("Произведение 1 столбца: " + sumColumn);
            Console.ReadKey();
        }
    }
}
