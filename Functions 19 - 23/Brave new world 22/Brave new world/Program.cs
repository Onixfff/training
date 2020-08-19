using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Brave_new_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int positionX = 0, positionY = 0;
            int positionDX = 0, positionDY = 0;

            int allDots = 0;
            int collectDots = 0;

            string mapName = "Map1";

            bool isPlayng = true;

            char[,] map = ReadMap(mapName, ref positionX, ref positionY, ref allDots);

            DrawMap(map);

            while (isPlayng)
            {
                Console.SetCursorPosition(0, 22);
                Console.Write($"Собрано {collectDots}/{allDots}");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey(true);
                    ChangeDirection(Key, ref positionDX, ref positionDY);
                }

                if (map[positionX + positionDX, positionY + positionDY] != '#')
                {
                    Move(ref positionX, ref positionY, positionDX, positionDY);
                    GainOfPoints(map, ref collectDots, positionX, positionY);
                }

                if(collectDots == allDots)
                {
                    isPlayng = false;
                    Console.SetCursorPosition(0,21);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Вы выйграли");
                    Console.ReadKey();
                }

                System.Threading.Thread.Sleep(170);
            } 
        }

        static void Move(ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(' ');

            X += DX;
            Y += DY;

            Console.SetCursorPosition(Y, X);
            Console.Write('@');
        }

        static void ChangeDirection(ConsoleKeyInfo Key, ref int DX, ref int DY)
        {
            switch (Key.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
            }
        }

        static char[,] ReadMap(string mapName, ref int positionX, ref int positionY, ref int allDots)
        {
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");

            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if (map[i, j] == '@')
                    {
                        positionX = i;
                        positionY = j;
                    }
                    else if (map[i, j] == '%')
                    {
                        allDots++;
                    }
                }
            }
            return map;
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void GainOfPoints(char[,] map, ref int collectDots, int X, int Y)
        {
            if (map[X, Y] == '%')
            {
                collectDots++;
                map[X, Y] = ' ';
            }
        }
    }
}
