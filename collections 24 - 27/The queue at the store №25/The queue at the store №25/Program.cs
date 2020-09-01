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

            for (int i = 0; i < maxBuyers; i++)
            {
                PurchaseAmount = rnd.Next(100, 10001);
                buyers.Enqueue(PurchaseAmount);
            }

            while (exit == false)
            {
                for(int i = 0; i < maxBuyers; i++)
                {
                    Console.WriteLine("Клиент номер - " + (i + 1) + "/" + maxBuyers + "\nСумма покупки - " + buyers.Peek());
                    Console.WriteLine("Банк = " + bank + " руб");
                    bank += buyers.Dequeue();
                    Console.ReadKey();
                    Console.Clear();
                }
                exit = true;
            }
        }
    }
}
