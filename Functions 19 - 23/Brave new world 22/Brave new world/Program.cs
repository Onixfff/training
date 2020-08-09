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
            string Map = "Map1";
            Console.CursorVisible = false;
            int positionX, positionY, coins = 0, mapCoins = 0,finish1 = 1; ;
            bool finishMap = true, endGame = true;
            while (endGame)
            {
                char[,] map = ReadMap(Map, out positionX, out positionY, ref mapCoins);

                while (finishMap)
                {
                    DrawMapAndHero(map, positionX, positionY);
                    HeroWalking(map, ref positionX, ref positionY);
                    TakeCoins(map,positionX,positionY,ref coins);
                    ClearMap(map);
                    SwitchMap(ref endGame, ref finishMap, ref Map, ref coins, ref mapCoins, ref finish1);
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

                    if(map[i,j] == '%')
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

        static void DrawMapAndHero(char[,] map, int positionX, int positionY)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(positionY, positionX);
            Console.Write('@');
        }

        static void SwitchMap(ref bool endGame, ref bool finishMap, ref string Map, ref int coins, ref int mapCoins,ref int numberMap)
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

        static void HeroWalking (char[,] map,ref int positionX, ref int positionY)
        {
            ConsoleKeyInfo charKey = Console.ReadKey();
            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[positionX - 1, positionY] != '#')
                    {
                        positionX -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[positionX + 1, positionY] != '#')
                    {
                        positionX += 1;
                    }

                    break;
                case ConsoleKey.LeftArrow:
                    if (map[positionX, positionY - 1] != '#')
                    {
                        positionY -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[positionX, positionY + 1] != '#')
                    {
                        positionY += 1;
                    }
                    break;
            }
        }
    }
}
