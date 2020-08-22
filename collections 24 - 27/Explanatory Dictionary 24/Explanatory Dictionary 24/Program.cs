using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanatory_Dictionary_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataType = new Dictionary<string, string>();

            bool exit = false;

            string userInput;
            dataType.Add("int", "Тип целочисленных значений." +
                "\nХранит данные от -2147483648 до 2147483647 и занимает 4 байта." +
                "\nПредставлен системным типом System.Int32" +
                "\nПример: int number = 18;");
            dataType.Add("byte", "Тип целочисленных значений." +
                "/nХранит данные от 0 до 255 и занимает 1 байт." +
                "\nПредставлен системным типом System.Byte" +
                "\nПример: byte number = 1");
            dataType.Add("sbyte", "Тип целочисленных значений." +
                "\nХранит данные от -128 до 127 и занимает 1 байт" +
                "\nПредставлен системным типом System.SByte" +
                "\nПример: sbyte number = -120;");
            dataType.Add("short", "Тип целочисленных значений." +
                "\nХранит целое число от -32768 до 32767 и занимает 2 байта." +
                "\nПредставлен системным типом System.Int16" +
                "\nПример: short number = 1299;");
            dataType.Add("ushort", "Тип целочисленных значений." +
                "\nХранит Данные от 0 до 65535 и занимает 2 байта." +
                "\nПредставлен системным типом System.UInt16" +
                "\nПример: ushort number = 444;");
            dataType.Add("uint", "Тип целочисленных значений." +
                "\nХранит Данные от 0 до 4294967295 и занимает 4 байта." +
                "\n Представлен системным типом System.UInt32" +
                "\nПример uint number = 1123213;:");
            dataType.Add("long", "Тип целочисленных значений." +
                "\nХранит Данные от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт." +
                "\n Представлен системным типом System.Int64" +
                "\nПример: long number = 9332333, number1 = 0xFF");
            dataType.Add("ulong", "Тип целочисленных значений." +
                "\nХранит Данные от 0 до 18 446 744 073 709 551 615 и занимает 8 байт." +
                "\nПредставлен системным типом System.UInt64" +
                "\nПример: ulong number = 99812 ,number1 = 0xFF;");
            dataType.Add("char", "Символьный тип данных" +
                "\nХранит одиночный символ в кодировке Unicode и занимает 2 байта." +
                "\nПредставлен системным типом System.Char." +
                "\nПример: char m = '@';");
            dataType.Add("string", "Строчний тип данных." +
                "\nхранит набор символов Unicode." +
                "\nПредставлен системным типом System.String." +
                "\nПример: string userInput = «Hello World!»");
            dataType.Add("float", "Тип цисел с плавающей точкой." +
                "\nХранит данных от -3.4*1038 до 3.4*1038 и занимает 4 байта." +
                "\nПредставлен системным типом System.Single." +
                "\nПример: float number = 13.4f");
            dataType.Add("double", "Тип цисел с плавающей точкой." +
                "\nХранит данные от ±5.0*10-324 до ±1.7*10308 и занимает 8 байт." +
                "\nПредставлен системным типом System.Double" +
                "\nПример: double number = 12.3");
            dataType.Add("bool", "Логический тип данных." +
                "\nХранащий значения true or false." +
                "\nПредставлен системным типом System.Boolean" +
                "\nПример: bool exit = false;");

            Console.WriteLine("Это словарь типов данных на языке c#");

            while (exit == false)
            {
                Console.WriteLine("Введите имя типа данных о котором хотите узнать или exit для выхода");
                userInput = Console.ReadLine().ToLower();

                bool found = false;

                found = dataType.ContainsKey(userInput);

                if (found)
                {
                    Console.Clear();
                    Console.WriteLine($"\t\tТип данных - {userInput}" +
                        $"\n{dataType[userInput]}\n");
                }
                else if(userInput == "exit")
                {
                    exit = true;
                }
                else
                {
                    Console.Clear();
                    Error("Такого типа данных нету", ConsoleColor.Red);
                }
            }
        }
        static void Error(string text, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine($"{text}\n");
            Console.ForegroundColor = defaultColor;
        }
    }
}
