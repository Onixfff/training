using System;
using System.Collections.Generic;
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
            int number = int.MinValue;
            int[,] A = new int [10,10];
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < A.GetLength(0); i++)
			{
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0,4}", A[i,j] = i * 10 + j + 1);
                    if (number < A[i, j])
                    {
                        number = A[i,  j];
                    }
                }
                Console.WriteLine();
		    }
            Console.WriteLine();
            Console.WriteLine("Полученная матрица: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (number == A[i, j])
                    {
                        A[i, j] = 0;
                    }
                    Console.Write("{0,4}",A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Наибольший эламент - " + number);
            Console.ReadKey();
        }
    }
}