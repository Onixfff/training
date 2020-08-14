using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.DesignerServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
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
            double userInput;
            TextOutput(text);
            UserInput(out userInput);
            FillingBar(userInput, position,color);            
            ClearLine(4);
        }

        static void TextOutput (string text)
        {
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(text);
        }

        static void UserInput(out double userInput)
        {
            userInput = Convert.ToDouble(Console.ReadLine());   
        }

        static void TransferAsAPercentage(ref double x)
        {
            int conversionToInterest = 10;
            x /= conversionToInterest;
            x = Math.Ceiling(x);
        }

        static void FillingBar(double userInput, int position, ConsoleColor color)
        {
            string Bar;
            double x = userInput;
            if (x <= 100)
            {
                TransferAsAPercentage(ref x);
                int drawingStage = 1;
                for (int i = 0; i < 2; i++)
                {
                    BarFill(x, drawingStage, out Bar);
                    DrawBar(Bar, position, color, userInput, ref drawingStage);
                }
            }
            else
            {
                Error(position,"Вы ввели неправельно проценты !");
            }
        }

        static void BarFill(double userInput, int drawingStage, out string Bar,char symbol = '#')
        {
            Bar = "";
            double barSize = 10;
            switch (drawingStage)
            {
                case 1:
                    for (int i = 0; i < userInput; i++)
                    {
                        Bar += symbol;
                    }
                    break;
                case 2:
                    for (double i = userInput; i < barSize; i++)
                    {
                        Bar += " ";
                    }
                    break;
            }
        }

        static void DrawBar(string Bar, int position, ConsoleColor color, double userInput, ref int drawingStage)
        {
            switch (drawingStage)
            {
                case 1:
                    ConsoleColor defaultColor = Console.BackgroundColor;
                    Console.SetCursorPosition(0, position);
                    Console.Write("[");
                    Console.BackgroundColor = color;
                    Console.Write(Bar);
                    Console.BackgroundColor = defaultColor;
                    drawingStage++;
                    break;
                case 2:
                    Console.Write(Bar + "] " + userInput + "%");
                    break;
            }
        }

        static void Error(int position, string text = "Ошибочка !", ConsoleColor color = ConsoleColor.Red)
        {
            Console.SetCursorPosition(0, position);
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = defaultColor;
        }

        static void ClearLine(int line)
        {
            Console.MoveBufferArea(0, line , Console.BufferWidth,1,Console.BufferWidth, line, ' ', Console.ForegroundColor,Console.BackgroundColor);
            Console.MoveBufferArea(0, line + 1, Console.BufferWidth, 1, Console.BufferWidth, line + 1, ' ', Console.ForegroundColor, Console.BackgroundColor);
        }
    }
}
