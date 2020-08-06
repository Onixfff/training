using System;
using System.Collections.Generic;
using System.Linq;
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
                DrawBar(ConsoleColor.Red,0,"Введите сколько у вас жизней до 101 ");
                ClearLine(4);
                DrawBar(ConsoleColor.Blue,1,"Введите сколько у вас маны до 101 ");
                ClearLine(4);
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(ConsoleColor color, int position, string text, char symbol = '#')
        {
            double defaultValue, value, maxValue = 10;

            Console.SetCursorPosition(0, 4);
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.WriteLine(text);
            value = Convert.ToSingle(Console.ReadLine());
            defaultValue = value;
            if (value <= 100)
            {
                string bar = "";
                value /= 10;
                value = Math.Ceiling(value);

                for (int i = 0; i < value; i++)
                {
                    bar += symbol;
                }

                Console.SetCursorPosition(0, position);
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defaultColor;

                bar = "";

                for (double i = value; i < maxValue; i++)
                {
                    bar += " ";
                }
                Console.Write(bar + "] " + defaultValue + "%");

            }
            else
                Error("Вы ввели неправельно проценты");
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
