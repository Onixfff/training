using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int health1, health2;
            float damage1, damage2;
            float protection1, protection2;
            string usingInput;
            //string hero;
            Random random = new Random();
            do
            {
                Console.WriteLine("Choose who you will play for: magician, swordsman.");
                usingInput = Console.ReadLine();
                
                
                switch (usingInput) 
                {
                    case "magician":

                        //1 - ShadowWord = дамаг и хилл.
                        //2 -

                        Console.WriteLine("Enter ability to find out all abilities.");
                        usingInput = Console.ReadLine();
                        if(usingInput == "ability")
                        {
                            Console.WriteLine("abilities:1-ShadowWord - hill on the hero or damage on the enemy = (10 , 50)" +
                            "\n2 - " +
                            "\n3 - ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        int ShadowWord = random.Next(10,51);
                        health1 = random.Next(50, 101);
                        protection1 = random.Next(health1, 101);
                        damage1 = random.Next(1, 6);

                        health2 = random.Next(100, 501);
                        protection2 = random.Next(health1, 101);
                        damage2 = random.Next(20, 71);

                        Console.WriteLine($"Stats hero:\nhp1 - {health1}, protection1 - {protection1}, damage1 - {damage1}.\n" +
                                          $"\nStats enemy:\nhp2 - {health2}, protection2 - {protection2}, damage 2 - {damage2}.");

                        Console.WriteLine();
                        Console.WriteLine("Сhoose a spell:\n1 - ShadowWord.\n2 - ");
                        usingInput = Console.ReadLine();
                        switch (usingInput)
                        {
                            case "1":
                                Console.WriteLine("Shadow Word on yourself or the enemy");
                                usingInput = Console.ReadLine();
                                switch (usingInput)
                                {
                                    case "yourself":
                                        health1 += ShadowWord;

                                        Console.WriteLine($"Stats hero:\nhp1 - {health1}, protection1 - {protection1}, damage1 - {damage1}.\n" +
                                          $"\nStats enemy:\nhp2 - {health2}, protection2 - {protection2}, damage 2 - {damage2}.");
                                        break;

                                    case "enemy":
                                        health2 -= ShadowWord;

                                        Console.WriteLine($"Stats hero:\nhp1 - {health1}, protection1 - {protection1}, damage1 - {damage1}.\n" +
                                          $"\nStats enemy:\nhp2 - {health2}, protection2 - {protection2}, damage 2 - {damage2}.");
                                        break;

                                    default:
                                        
                                        break;
                                }
                                //Надо сделать чтобы shadowWord был или на себя или на enemy
                                //ShadowWord = random.Next(10, 51);
                                //health1 += ShadowWord;
                                break;
                            default:
                                Console.WriteLine(" no such ability");
                                break;
                        }

                        break;

                    case "swordsman":
                        int swordStrike;

                        break;
                }
                Console.WriteLine(" start over? yes or no");
                usingInput = Console.ReadLine();
            } while (usingInput != "no");
        }
    }
}
