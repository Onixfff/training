using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputUsing;
            int height;
            int wight;
            string name;
            string password;

            Console.Write("Введите имя:");
            name = Console.ReadLine();

            Console.Write("Введите пароль:");
            password = Console.ReadLine();
            Console.Clear();
            
            do
            {
                //Etc-Выход из программы

                Console.WriteLine("Введите номер команды чтобы начать её");
                Console.WriteLine("Команды: \n1 - Очистить консоль.\n2 - Покрасить консоль.\n3 - Изменить размер программы.\n4 - Сменить имя.\n5 - Сменить пароль.\n6 - Выйти из прогрограммы.");
                Console.WriteLine();
                InputUsing = Console.ReadLine();
                switch(InputUsing)
                {
                    case "1":
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Консоль очистится");
                        Console.WriteLine("Покрасить задний фон в: \n1 - Red.\n2 - Cyan.\n3 - Magenta.\n4 - Вернуть начальный цвет");
                        Console.WriteLine();
                        InputUsing = Console.ReadLine();
                        switch (InputUsing)
                        {   case "1":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;

                            case "2":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.Clear();
                                break;

                            case "3":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                Console.Clear();
                                break;
                            case "4":
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Такого цвета нет");
                                break;
                        }

                        break;
                    case "3":
                        Console.Write("Введите ширину: ");
                        wight = Convert.ToInt32(Console.ReadLine());
                        Console.WindowWidth = wight;

                        Console.Write("Введите высоту: ");
                        height = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = height;

                        break;
                    case "4":
                        for(int i = 3; i >= 0; i--)
                        {
                            Console.Write("Введите старое имя: ");
                            InputUsing = Console.ReadLine();
                            if(InputUsing == name)
                            {
                                Console.Write("Введите новое имя: ");
                                name = Console.ReadLine();
                                break;
                            }
                            else if (InputUsing != name)
                            {
                                Console.WriteLine($"Вы ввели неправельное имя. Попыток осталось: {i}");
                            }
                        }
                        break;
                    case "5":
                        for(int i = 3; i >= 0; i--)
                        {
                            Console.Write("Введите старый пороль: ");
                            InputUsing = Console.ReadLine();
                            if(InputUsing == password)
                            {
                                Console.Write("Введите новый пороль: ");
                                password = Console.ReadLine();
                                break;
                            }
                            else if (InputUsing != password)
                            {
                                Console.WriteLine($"Вы ввели неправельный пороль. Попыток осталось: {i}");
                            }
                        }                    
                        break;
                    case "6":
                        Console.WriteLine("Введите своё имя и пороль чтобы выйти из приложения");
                        for (int i = 3; i >= 0; i--) 
                        {
                            Console.Write("Введите Имя: ");
                            InputUsing = Console.ReadLine();
                            if(InputUsing == name)
                            {
                                    Console.Write("Введите Пороль: ");
                                    InputUsing = Console.ReadLine();
                                    if(InputUsing == password)
                                    {
                                        InputUsing = "Etc";
                                        break;
                                    }
                                    else if(InputUsing != password)
                                    {   
                                        Console.WriteLine($"Вы ввели неправельный пороль. Попыток осталось {i}");
                                    }
                            }
                            else if(InputUsing != name)
                            {
                                Console.WriteLine($"Вы ввели неправельное имя. Попыток осталось: {i}");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            } while (InputUsing != "Etc");
        }
    }
}