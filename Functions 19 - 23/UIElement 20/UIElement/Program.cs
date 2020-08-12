using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.DesignerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace UIElement
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CreateBar("Введите сколько у вас жизней  0 - 100 ", ConsoleColor.Red, 0);
                CreateBar("Введите сколько у вас маны  0 - 100", ConsoleColor.Blue, 1);
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void CreateBar(string text, ConsoleColor color, int position)
         {
            string startBar, endBar;
            double userInput; 
            TextOutput(text);
            UserInput( out userInput);
            FillingBar(userInput, out startBar, out endBar);
            DrawBar(startBar, endBar, position, color, userInput);
            ClearLine(4);
        }

        static void TextOutput (string text)
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(text);
        }

        static double UserInput(out double userInput)
        {
            userInput = Convert.ToDouble(Console.ReadLine());
            return userInput;
        }

        static void FillingBar(double userInput, out string startBar, out string endBar, char symbol = '#')
        {
            double barSize = 10;
            int conversionToInterest = 10;
            startBar = "";
            endBar = startBar;

            if (userInput <= 100)
            {
                userInput /= conversionToInterest;
                userInput = Math.Ceiling(userInput);

                for (int i = 0; i < userInput; i++)
                {
                    startBar += symbol;
                }

                for (double i = userInput; i < barSize; i++)
                {
                    endBar += " ";
                }
            }
            else
            {
                Error("Вы ввели неправельно проценты");
            }
        }

        static void DrawBar(string startBar, string endBar, int position, ConsoleColor color, double userInput)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(startBar);
            Console.BackgroundColor = defaultColor;
            Console.Write(endBar + "] " + userInput + "%");
        }

        static void Error(string text = "Ошибочка !", ConsoleColor color = ConsoleColor.Red)
        {
            Console.SetCursorPosition(0, 0);
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.Write(text);
            Console.BackgroundColor = defaultColor;
        }

        static void ClearLine(int line)
        {
            Console.MoveBufferArea(0, line , Console.BufferWidth,1,Console.BufferWidth, line, ' ', Console.ForegroundColor,Console.BackgroundColor);
            Console.MoveBufferArea(0, line + 1, Console.BufferWidth, 1, Console.BufferWidth, line + 1, ' ', Console.ForegroundColor, Console.BackgroundColor);
        }
    }
}
