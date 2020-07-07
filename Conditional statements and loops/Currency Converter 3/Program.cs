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
        {   do()
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
                Console.WriteLine("2-Обменять доллары");
                Console.WriteLine("3-Обменять евро");
                userTnput = Console.ReadLine();

                switch(userTnput)
                {
                    case "1":
                    Console.WriteLine("Обмен рублей");
                    Console.WriteLine("1-Обменять на доллары");
                    Console.WriteLine("2-Обменять на евро");
                    userTnput = Console.ReadLine();

                    switch(userTnput)
                    {
                        case "1":
                        Console.WriteLine("Обмен рублей на доллары");
                        break;

                        case "2":
                        Console.WriteLine("Обмен рублей на евро");
                        break;        
                    }
                    break;
                
                    case "2":
                    Console.WriteLine("Обмен долларов");
                    Console.WriteLine("1-Обменять на рубли");
                    Console.WriteLine("2-Обменять на евро");
                    userTnput = Console.ReadLine();

                    switch(userTnput)
                    {
                        case "1":
                        Console.WriteLine("Обмен долларов на рубли");
                        break;

                        case "2":
                        Console.WriteLine("Обмен долларов на евро");
                        break;        
                    }
                    break;

                    case "3":
                    Console.WriteLine("Обмен евро");
                    Console.WriteLine("1-Обменять на рубли");
                    Console.WriteLine("2-Обменять на доллары");
                    userTnput = Console.ReadLine();

                    switch(userTnput)
                    {
                        case "1":
                     Console.WriteLine("Обмен евро на рубли");
                        break;

                        case "2":
                        Console.WriteLine("Обмен евро на доллары");
                        break;        
                    }
                    break;                
                }
            }while(userTnput != "exit" && userTnput != "Exit")
        }
    }
}
