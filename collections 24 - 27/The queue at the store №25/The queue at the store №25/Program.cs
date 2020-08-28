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
            int buyer = 1;

            bool exit = false;

            while (exit == false)
            {
                if (buyers.Count < maxBuyers)
                {
                    buyers.Enqueue(buyer);
                    Console.WriteLine($"На кассе в очереди {buyers.Count}/{maxBuyers}");
                    Console.WriteLine("Клиент №" + buyers.Count);
                    Console.Write("Введите суму покупки - ");
                    PurchaseAmount = Convert.ToInt32(Console.ReadLine());
                    bank += PurchaseAmount;
                    buyer++;
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
