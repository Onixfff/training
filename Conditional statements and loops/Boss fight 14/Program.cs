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

            float healthHero, healthEnemy, protectionHero, protectionEnemy;
            int damageHero, damageEnemy;
            bool devil = false;
            int ShadowWord;
            string usingInput;

            Random random = new Random();

            healthHero = random.Next(90, 161);
            protectionHero = random.Next(30, 101);
            damageHero = random.Next(1, 6);

            healthEnemy = random.Next(500, 1001);
            protectionEnemy = random.Next(76, 101);
            damageEnemy = random.Next(20, 80);

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
            Console.WriteLine($"Stats hero:\nhp - {healthHero}, damage - {damageHero}.\n" +
                          $"\nStats enemy:\nhp - {healthEnemy}, damage - {damageEnemy}.");
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
                                healthHero += ShadowWord;
                                break;
                            case "2":
                                healthEnemy -= ShadowWord;
                                break;
                            default:
                                Console.WriteLine("so you can’t use the ability");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "2":
                        healthHero -= Convert.ToSingle(damageEnemy) / 100 * protectionEnemy;
                        if (healthHero <= 0)
                        {
                            healthHero = random.Next(100, 181);
                        }
                        break;
                    case "3":
                        int devilesExit = random.Next(10, 20);
                        if (devil == false)
                        {
                            healthEnemy -= devilesExit;
                            healthHero -= devilesExit;
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
                            int damageDevil;
                            damageDevil = random.Next(100, 300);
                            healthEnemy -= Convert.ToSingle(damageDevil) / 100 * protectionEnemy;
                            Console.WriteLine("damage 3 - " + damageDevil);
                        }
                        else if (devil == false)
                        {
                            Console.WriteLine("you can not use this magic until the demon");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        healthEnemy -= Convert.ToSingle(damageHero) / 100 * protectionEnemy;
                        break;
                    default:
                        Console.WriteLine(" no such ability");
                        break;
                }
                healthHero -= Convert.ToSingle(damageEnemy) / 100 * protectionEnemy;

                Console.WriteLine();
                Console.WriteLine($"Stats hero:\nhp - {healthHero}, damage - {damageHero}.\n" +
                              $"\nStats enemy:\nhp - {healthEnemy}, damage - {damageEnemy}.");

            } while (healthHero > 0 && healthEnemy > 0);
            
            Console.WriteLine();
            if (healthHero <= 0 && healthEnemy <= 0)

            {
                Console.WriteLine("draw");
            }
            else if (healthHero <= 0)
            {
                Console.WriteLine("your hero fell");
            }
            else if (healthEnemy <= 0)
            {
                Console.WriteLine("the enemy fell");
            }
            Console.ReadKey();
        }
    }
}