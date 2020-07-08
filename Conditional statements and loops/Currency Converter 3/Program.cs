using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_6
{
    class Program
    {
        static void Main(string[] args)
        {   
            float rubInEur = 80.3f, eurInRub = 80.71f, rubInUsd = 70.7f, usdInRub = 71.25f, eurInUsd = 1.13f, usdInEur = 0.88f;
            float rub;
            float usd;
            float eur;
            string userInput;

            Console.WriteLine("Добро пожаловать в нашь обменник.");
            Console.WriteLine("Здесь вы сможете обменять свои рубли на долары, рубли на евро, "
        + " долары на рубли, долары на евро, евро на рубли, евро на долары.");

            do
            {
                Console.WriteLine();
                Console.Write("Введите сколько у вас рублей: ");
                rub = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите сколько у вас долларов: ");
                usd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите сколько у вас евро: ");
                eur = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("1-Обменять рубли");
                Console.WriteLine("2-Обменять доллары");
                Console.WriteLine("3-Обменять евро");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Обмен рублей");
                        Console.WriteLine("1-Обменять на доллары");
                        Console.WriteLine("2-Обменять на евро");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine();
                                Console.WriteLine("Обмен рублей на доллары");
                                usd += rub / rubInUsd;
                                rub -= rub;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Обмен рублей на евро");
                                eur += rub / rubInEur;
                                rub -= rub;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Такой кнопки нету");
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Обмен долларов");
                        Console.WriteLine("1-Обменять на рубли");
                        Console.WriteLine("2-Обменять на евро");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine();
                                Console.WriteLine("Обмен долларов на рубли");
                                rub += usd * usdInRub;
                                usd -= usd;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Обмен долларов на евро");
                                eur += usd * usdInEur;
                                usd -= usd;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Такой кнопки нету");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Обмен евро");
                        Console.WriteLine("1-Обменять на рубли");
                        Console.WriteLine("2-Обменять на доллары");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine();
                                Console.WriteLine("Обмен евро на рубли");
                                rub += eur * eurInRub;
                                eur -= eur;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine("Обмен евро на доллары");
                                usd += eur * eurInUsd;
                                eur -= eur;
                                Console.WriteLine($"После обмена у вас осталось {rub} рублей, {usd} долларов и {eur} евро на вашем счету.");
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Такой кнопки нету");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Такой кнопки нету");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Введите любой символ чтобы продолжить или exit чтобы выйти");
                userInput = Console.ReadLine();
            }while (userInput != "exit" && userInput != "Exit");
        }
    }
}
