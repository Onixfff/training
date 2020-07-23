using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   int sumLine, sumColumn;
            int[,] arr = {
                {1,3,6},
                {4,7,8},
                {2,4,1}
            };
            for (int i = 0; i < arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j]+ " | ");
                }
                Console.WriteLine();
            }
            sumLine = arr[1, 0] + arr[1, 1] + arr[1, 2];
            sumColumn = arr[0, 0] * arr[1, 0] * arr[2, 0];
            Console.WriteLine("Сумма 2 строки: "+sumLine);
            Console.WriteLine("Произведение 1 столбца: "+sumColumn);
            Console.ReadKey();
        }
    }
}
