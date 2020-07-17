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

            float health1, health2, protection1, protection2;
            int damage1, damage2;
            bool devil = false;
            int ShadowWord;
            string usingInput;

            Random random = new Random();

            health1 = random.Next(90, 161);
            protection1 = random.Next(30, 101);
            damage1 = random.Next(1, 6);

            health2 = random.Next(500, 1001);
            protection2 = random.Next(76, 101);
            damage2 = random.Next(20, 80);

            Console.WriteLine("Enter ability to find out all abilities.");
            usingInput = Console.ReadLine();
            if (usingInput == "ability")
            {
                    Console.WriteLine("1-Shadow Word - hill on the hero or damage on the enemy = 100-130 damage or heal" +
                    "\n2 - reborn - if xp fall to 0 they will be restored randomly 40-100 damage" +
                    "\n3 - devil's exit - a gap in the floor opens and the devil comes out with damage on the hero = 10 - 20 damege, and on the enemy = 10 - 20 damege" +
                    "\n4 - demon punishment - you order to inflict damage to the demon in your enemy = 100-300 damege" +
                    "\n5 - staff strike - the magician beats with his staff = 1-6 damege");
                    Console.ReadKey();
                    Console.Clear();
            }

            Console.WriteLine();
            Console.WriteLine($"Stats hero:\nhp1 - {health1}, damage1 - {damage1}.\n" +
                          $"\nStats enemy:\nhp2 - {health2}, damage 2 - {damage2}.");
            do
            {
                ShadowWord = random.Next(100, 131);
                Console.WriteLine();
                Console.WriteLine("Сhoose a spell:\n1 - Shadow Word.\n2 - reborn.\n3 - devil's exit.\n4 - demon punishment.\n5 - staff strike.");
                Console.WriteLine();
                usingInput = Console.ReadLine();
                switch (usingInput)
                {
                    case "1":
                        Console.WriteLine("Shadow Word on 1 - yourself or the 2 - enemy");
                        usingInput = Console.ReadLine();
                        switch (usingInput)
                        {
                            case "1":
                                health1 += ShadowWord;
                                break;
                            case "2":
                                health2 -= ShadowWord;
                                break;
                            default:
                                Console.WriteLine("so you can’t use the ability");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "2":
                        health1 -= Convert.ToSingle(damage2) / 100 * protection2;
                        if (health1 <= 0)
                        {
                            health1 = random.Next(100, 181);
                        }
                        break;
                    case "3":
                        int devilesExit = random.Next(10, 20);
                        if (devil == false)
                        {
                            health2 -= devilesExit;
                            health1 -= devilesExit;
                            devil = true;
                        }
                        else if (devil == true)
                        {
                            Console.WriteLine("you already called the demon");
                        }
                        break;
                    case "4":
                        if (devil == true)
                        {
                            int damage3;
                            damage3 = random.Next(100, 300);
                            health2 -= Convert.ToSingle(damage3) / 100 * protection2;
                            Console.WriteLine("damage 3 - " + damage3);
                        }
                        else if (devil == false)
                        {
                            Console.WriteLine("you can not use this magic until the demon");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        health2 -= Convert.ToSingle(damage1) / 100 * protection2;
                        break;
                    default:
                        Console.WriteLine(" no such ability");
                        break;
                }
                health1 -= Convert.ToSingle(damage2) / 100 * protection2;

                Console.WriteLine();
                Console.WriteLine($"Stats hero:\nhp1 - {health1}, damage1 - {damage1}.\n" +
                              $"\nStats enemy:\nhp2 - {health2}, damage 2 - {damage2}.");

            } while (health1 > 0 && health2 > 0);
            
            Console.WriteLine();
            if (health1 <= 0 && health2 <= 0)

            {
                Console.WriteLine("draw");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("your hero fell");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("the enemy fell");
            }
            Console.ReadKey();
        }
    }
}