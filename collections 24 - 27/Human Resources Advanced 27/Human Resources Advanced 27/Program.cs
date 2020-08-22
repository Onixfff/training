using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Advanced_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> workers = new List<string>();
            List<string> position = new List<string>();

            bool exit = false;

            int operation;
            int index = 0;

            while (exit == false)
            {
                Console.WriteLine("1 - добавить досье, 2 - вывести все досье, 3 - удалить досье, 4 - выход");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        UserInput(workers, "Введите ФИО");
                        Console.Clear();
                        UserInput(position, "Введите должность");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("ФИО\t\t\t\tДолжность");
                        for (int i = 0; i < workers.Count; i++)
                        {
                            Console.WriteLine(workers[i] + " - " + position[i]);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Удаление по индексу" +
                        "\nВведите индекс - ");
                        index = Convert.ToInt32(Console.ReadLine());
                        index--;
                        workers.RemoveAt(index);
                        position.RemoveAt(index);
                        break;
                    case 4:
                        exit = true;
                        break;
                }
                Console.WriteLine();
            }
        }

        static List<string> UserInput(List<string> array, string text)
        {
            string userInput;
            Console.WriteLine(text);
            userInput = Console.ReadLine();
            array.Add(userInput);
            return array;
        }
    }
}
