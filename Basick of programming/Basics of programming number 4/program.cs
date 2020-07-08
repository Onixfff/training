using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystals;
            int gold;
            int price = 2;
            Console.WriteLine("Введите какое кол-во gold у вас есть:");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("купить crystals по цене 2 gold = 1 crystals");
            Console.ReadKey();
            crystals = gold / price;
            gold -= crystals * price;
            Console.WriteLine($"Вы смогли купить {crystals} crystals и у вас осталось {gold} gold");
            Console.ReadKey();
        }
    }
}
