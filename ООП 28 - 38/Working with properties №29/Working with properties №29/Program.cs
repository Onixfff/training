using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_properties__29
{
    class Program
    {
        static void Main(string[] args)
        {
            Render rendered = new Render();
            Player player = new Player(2,22);

            rendered.DrawPlayer(player.X, player.Y);
            Console.ReadKey();
        }
    }

    class Player
    {
        public int Y { get; private set; }

        public int X { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Render
    {
        public void DrawPlayer(int x, int y, char ch = '@')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }  
    }
}
