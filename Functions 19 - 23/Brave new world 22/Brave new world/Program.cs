using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Threading;

namespace Brave_new_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            string Map = "Map1";

            int positionX, positionY, coins = 0, mapCoins = 0, numberMap = 1;

            bool finishMap = true, endGame = true, isPlayng = true;

            while (endGame)
            {
                char[,] map = ReadMap(Map, out positionX, out positionY, ref mapCoins);

                while (finishMap)
                {
                    SwitchMap(ref endGame, ref finishMap, ref Map, ref coins, ref mapCoins, ref numberMap);
                    DrawMap(map);
                    //DrawHero(ref positionX, ref positionY);
                    IsPlayng(map, ref positionX, ref positionY, isPlayng);
                    TakeCoins(map, positionX, positionY, ref coins);
                    ClearMap(map);
                }
                finishMap = true;
            }
        }

        static char[,] ReadMap(string mapName, out int positionX, out int positionY, ref int mapCoins)
        {
            positionX = 0;
            positionY = 0;
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if (map[i, j] == '%')
                    {
                        mapCoins += 1;
                    }

                    if (map[i, j] == '@')
                    {
                        positionX = i;
                        positionY = j;
                        map[i, j] = ' ';
                    }
                }
            }
            return map;
        }

        static void ClearMap(char[,] map)
        {
            Console.MoveBufferArea(Console.WindowLeft, Console.WindowTop, map.GetLength(0), map.GetLength(1), 0, 0);
        }

        static void TakeCoins(char[,] map, int positionX, int positionY, ref int coins)
        {
            if (map[positionX, positionY] == '%')
            {
                coins += 1;
                map[positionX, positionY] = ' ';
            }
            Console.SetCursorPosition(0, 17);
            Console.Write("Coins: " + coins);
            Console.SetCursorPosition(0, 0);
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

        static void SwitchMap(ref bool endGame, ref bool finishMap, ref string Map, ref int coins, ref int mapCoins, ref int numberMap)
        {
            switch (numberMap)
            {
                case 1:
                    if (coins == mapCoins)
                    {
                        numberMap += 1;
                        finishMap = false;
                        Map = "Map2";
                        coins = 0;
                        mapCoins = 0;
                        Console.Clear();
                    }
                    break;
                case 2:
                    if (coins == mapCoins)
                    {
                        numberMap += 1;
                        finishMap = false;
                        Console.Clear();
                    }
                    break;
                default:
                    endGame = false;
                    finishMap = false;
                    Console.Clear();
                    Console.WriteLine("Конец игры !!!");
                    Console.ReadKey();
                    break;
            }
        }

        static void DrawHero(int x, ref int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write('@');
        }

        static ConsoleKeyInfo Readout()
        {
            ConsoleKeyInfo charKey = Console.ReadKey(true);
            return charKey;
        }

        static void IsPlayng(char[,] map, ref int positionX, ref int positionY, bool isPlayng)
        {
            while (isPlayng)
            {
                int positionDX = 0, positionDY = 0;
                if (Console.KeyAvailable)
                {
                    ChangeDirection(Readout(), ref positionDX, ref positionDY);

                }

                if (map[positionX + positionDX, positionY + positionDY] != '#')
                {
                    Move(ref positionX, ref positionY, positionDX, positionDY);
                }

                System.Threading.Thread.Sleep(200);
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

        static void ChangeDirection(ConsoleKeyInfo charKey ,ref int DX, ref int DY)
        {
            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
            }
        }
    }
}
