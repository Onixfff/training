using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float eur;
            string userTnput;
            float currencyCount;

            rub = Convert.ToSingle(Console.ReadLine());
            usd = Convert.ToSingle(Console.ReadLine());
            eur = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Добро пожаловать в нашь обменник." +
            +" Здесь вы сможете обменять свои рубли на долары, рубли на евро,"
            +" долары на рубли, долары на евро, евро на рубли, евро на долары.");
            Console.WriteLine("1-Обменять рубли");
            Console.WriteLine("2-Обменять долары");
            Console.WriteLine("3-Обменять евро");

            switch(userTnput)
            {
                case "1" 
                
            }
        }
    }
}
