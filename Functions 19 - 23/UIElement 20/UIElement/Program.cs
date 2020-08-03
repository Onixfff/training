using System;
using System.Collections.Generic;
using System.Linq;
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
                int health = 2, maxHealth = 10;
                int mana = 3, maxMana = 10;
                Console.SetCursorPosition(0, 4);
                Console.CursorVisible = true;
                Console.Write("Введите число, на которое изменится жизни: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число, на которое изменится мана: ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.CursorVisible = false;
                drawBar(health, maxHealth, ConsoleColor.Red, 0);
                drawBar(mana, maxMana, ConsoleColor.Blue, 1);
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void drawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '#')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

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

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }
            Console.Write(bar + "]");
        }
    }
}
