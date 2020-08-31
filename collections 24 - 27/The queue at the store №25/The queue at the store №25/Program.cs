using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_queue_at_the_store__25
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> buyers = new Queue<int>();

            Random rnd = new Random();

            int bank = 0;
            int PurchaseAmount;
            int maxBuyers = rnd.Next(10, 21);

            bool exit = false;

            for(int i = 0; i < maxBuyers; i++)
            {
                buyers.Enqueue(i);
            }

            while (exit == false)
            {
                if (buyers.Count != 0)
                {
                    Console.WriteLine("Покупателей осталось - " + buyers.Count);
                    Console.Write("Введите суму покупки - ");
                    PurchaseAmount = Convert.ToInt32(Console.ReadLine());
                    bank += PurchaseAmount;
                    buyers.Dequeue();
                    Console.WriteLine("Банк - " + bank);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    exit = true;
                }
            }
            Console.ReadKey();
        }
    }
}
