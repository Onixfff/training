using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
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
            string[] name = new string[0];
            string[] surname = new string[0];
            string[] patronymic = new string[0];
            string[] position = new string[0];

            while (exit)
            {
                Console.WriteLine("{0,10}", "Меню");
                Console.WriteLine("1: Добавить досье.\n2: Вывести все досье.\n3: Удалить досье.\n4: Поиск по фамилии\n5: Выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        name = addition(name, name.Length,"Введите имя: ");
                        surname = addition(surname, surname.Length,"Введите фамилию: ");
                        patronymic = addition(patronymic, patronymic.Length,"Введите отчество: ");
                        position = addition(position, position.Length,"Введите должность: ");
                        break;
                    case "2":
                        showAll(name, surname, patronymic, position);
                        break;
                    case "3":
                        int index;
                        Console.WriteLine("Введите номер договора для удаления");
                        index = Convert.ToInt32(Console.ReadLine());
                        deleteDossier(ref name, index);
                        deleteDossier(ref surname, index);
                        deleteDossier(ref patronymic, index);
                        deleteDossier(ref position, index);
                        break;
                    case "4":
                        searchBySurname(name, surname, patronymic, position);
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
        static string[] addition(string[] arrayName, int size,string text)
        {
            string userInput;
            Console.Write(text);
            userInput = Console.ReadLine();

            string[] newName = new string[size + 1];

            for (int i = 0; i < arrayName.Length; i++)
            {
                newName[i] = arrayName[i];
            }
            arrayName = newName;
            arrayName[arrayName.Length - 1] = userInput.ToLower();
            return arrayName;
        }
        static void showAll(string[] name, string[] surname, string[] patronymic, string[] position)
        {
            Console.WriteLine("# - " + "Имя - " + "Фамилия - " + "Отчество - " + "Должность");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + name[i] + " - " + surname[i] + " - " + patronymic[i] + " - " + position[i]);
            }
        }
        static string[] deleteDossier(ref string[] array, int index)
        {
            index --;
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
        static void clear(string[] array)
        {
            int number;
            Console.WriteLine("Введите номер договора для удаления");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (number - 1 == i)
                {
                    Array.Clear(array, i, i + 1);
                }
                
            }
        }
        static void searchBySurname(string[] name, string[] surname, string[] patronymic, string[] position)
        {
            string usingInput;
            Console.Write("Введите фамилию: ");
            usingInput = Console.ReadLine();
            for (int i = 0; i < surname.Length; i++)
            {
                if (usingInput.ToLower() == surname[i])
                {
                    Console.WriteLine("# - " + "Имя - " + "Фамилия - " + "Отчество - " + "Должность");
                    Console.WriteLine(i + 1 + " - " + name[i] + " - " + surname[i] + " - " + patronymic[i] + " - " + position[i]);
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
