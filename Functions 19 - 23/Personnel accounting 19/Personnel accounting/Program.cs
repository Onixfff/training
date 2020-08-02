using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Personnel_accounting
{
    class Program
    {

        static void Main(string[] args)
        {
            bool exit = true;
            string userInput;
            string[] position = new string[0];
            string[,] fullName = new string[3, 0];
            while (exit)
            {
                Console.WriteLine("{0,10}", "Меню");
                Console.WriteLine("1: Добавить досье.\n2: Вывести все досье.\n3: Удалить досье.\n4: Поиск по фамилии\n5: Выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        fullName = addingAnArray(fullName);
                        position = addingAnArray(position);
                        break;
                    case "2":
                        showAll(fullName, position);
                        break;
                    case "3":
                        int index;
                        Console.WriteLine("Введите номер договора для удаления");
                        index = Convert.ToInt32(Console.ReadLine());
                        deleteArrayByIndex(ref position, index);
                        deleteArrayByIndex(ref fullName, index);
                        break;
                    case "4":
                        searchBySurname(fullName, position);
                        break;
                    case "5":
                        exit = false;
                        break;
                    default:
                        error("Скорее всего вы нажали не на ту кнопку!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string[] addingAnArray(string[] arrayName)
        {
            string userInput;
            userInput = textOutput("Введите должность: ").ToLower();

            string[] newName = new string[arrayName.Length + 1];

            for (int i = 0; i < arrayName.Length; i++)
            {
                newName[i] = arrayName[i];
            }
            arrayName = newName;
            arrayName[arrayName.Length - 1] = userInput;
            return arrayName;
        }

        static string[,] addingAnArray(string[,] array)
        {
            string name, surname, patronymic;

            name = textOutput("Введите имя: ");
            surname = textOutput("Введите фамилию: ");
            patronymic = textOutput("Введите отчество: ");

            string[,] newArray = new string[array.GetLength(0), array.GetLength(1) + 1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }
            array = newArray;
            array[0, array.GetLength(1) - 1] = name;
            array[1, array.GetLength(1) - 1] = surname;
            array[2, array.GetLength(1) - 1] = patronymic;
            return array;
        }

        static string textOutput(string text)
        {
            string userInput;
            Console.Write(text);
            userInput = Console.ReadLine().ToLower();
            return userInput;
        }

        static void showAll(string[,] fullName, string[] position)
        {
            Console.WriteLine("#  - " + " Имя  - " + " Фамилия  - " + " Отчество  - " + " Должность");

            int index = 1;
            for (int x = 0; x < position.Length; x++)
            {
                Console.Write(x + 1 + " - ");
                for (int i = 0; i < fullName.GetLength(0); i++)
                {
                    for (int j = index - 1; j < index; j++)
                    {
                        Console.Write(fullName[i, j] + " - ");
                    }
                }
                index++;
                Console.Write(position[x]);
                Console.WriteLine();
            }
        }

        static string[] deleteArrayByIndex(ref string[] array, int index)
        {
            index--;
            string[] newArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
            return array;
        }

        static string[,] deleteArrayByIndex(ref string[,] array, int index)
        {
            index--;
            string[,] newArray = new string[array.GetLength(0), array.GetLength(1) - 1];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < index; j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = index + 1; j < array.GetLength(1); j++)
                {
                    newArray[i, j - 1] = array[i, j];
                }
            }
            array = newArray;
            return array;
        }

        static void searchBySurname(string[,] fullName, string[] position)
        {
            string userInput;
            Console.Write("Введите фамилию: ");
            userInput = Console.ReadLine().ToLower();
            Console.WriteLine("#  - " + " Имя  - " + " Фамилия  - " + " Отчество  - " + " Должность");
            int index = 1;

            for (int i = 0; i < fullName.GetLength(0); i++)
            {
                for (int j = 0; j < fullName.GetLength(1); j++)
                {
                    if (userInput == fullName[i,j])
                    {
                        Console.Write(index + " - ");
                        for (int x = 0; x < fullName.GetLength(0); x ++)
                        {
                            for (int y = j; y < fullName.GetLength(1); y = fullName.GetLength(1) )
                            {
                                Console.Write(fullName[x, y] + " - ");
                            }
                        }
                        index++;
                        Console.Write(position[j] + "\n");
                    }
                }
            }

        }

        static void error(string textError)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0, 20}","Ошибка!");
            Console.WriteLine(textError+"\a\nЧтобы начать занова нажмите на любую кнопку");
            Console.ForegroundColor = defaultColor;
        }
    }
}
