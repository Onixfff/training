using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_database_30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase(new Player[] { new Player("Антоха", 32, false), new Player("Егор", 1, false), new Player("Петр", 99, true) });

            string userInput;

            bool exit = false;

            while (exit == false)
            {
                Console.Write("Команды:\n1.Добавить Игрока\n2.Удалить игрока\n3.Забанить игрока\n4.Разбанить игрока\n5.Вывести всю базу игроков\n6.Выйти из программы\n\nВыбор - ");
                userInput = Convert.ToString(Console.ReadLine());

                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Добавление игрока");
                        string name;

                        int lvl;

                        bool ban;

                        Console.Write($"Введите имя: ");
                        name = Convert.ToString(Console.ReadLine());

                        Console.Write($"Введите lvl: ");
                        lvl = Convert.ToInt32(Console.ReadLine());

                        dataBase.AddPlayer(name,lvl);
                        break;
                    case "2":
                        Console.WriteLine("Удаление игрока по id");

                        Console.Write("Введите id игрока для удаления: ");
                        userInput = Console.ReadLine();

                        dataBase.RemovePlayer(Convert.ToInt32(userInput));
                        break;
                    case "3":
                        Console.WriteLine("Забанить игрока по id");

                        Console.Write("Введите id игрока для бана: ");
                        userInput = Console.ReadLine();

                        dataBase.BanUnbanPlayer(Convert.ToInt32(userInput), true);

                        break;
                    case "4":
                        Console.WriteLine("Разбан игрока по id");

                        Console.Write("Введите id игрока для разбана: ");
                        userInput = Console.ReadLine();

                        dataBase.BanUnbanPlayer(Convert.ToInt32(userInput), false);
                        break;
                    case "5":
                        dataBase.showPlayers();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Такой команды нету");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class DataBase
    {
        public Player[] Players;

        public DataBase(Player[] players)
        {
            Players = players;
        }

        public void showPlayers()
        {
            Console.Clear();

            for (int i = 0; i < Players.Count(); i++)
            {
                Console.WriteLine($"№ - {i + 1}");
                Players[i].Show();
                Console.WriteLine("---------------------------------");
            }
        }
        public void AddPlayer(string name, int lvl, bool ban = false)
        {
            Player[] playersNew = new Player[Players.Length + 1];

            for(int i = 0; i < Players.Length; i++)
            {
                playersNew[i] = Players[i];
            }
            playersNew[playersNew.Length - 1] = new Player(name, lvl, ban);

            Players = playersNew;

        }

        public void RemovePlayer(int index)
        {
            index--;

            Player[] playersRemove = new Player[Players.Length - 1];

            for(int i = 0; i < index; i++)
            {
                playersRemove[i] = Players[i];
            }
            for(int i = index + 1; i < Players.Length; i++)
            {
                playersRemove[i - 1] = Players[i];
            }

            Players = playersRemove;
        }

        public void BanUnbanPlayer(int index, bool ban)
        {
            index--;

            for(int i = 0; i < Players.Length; i++)
            {
                if(index == i)
                {
                    if (ban == false)
                        Players[i].Unban();
                    else
                        Players[i].Ban();
                }
            }
        }
    }

    class Player
    {
        public string Name;

        public int Lvl;
        
        public bool Block;

        public Player(string name, int lvl, bool block)
        {
            Name = name;
            Lvl = lvl;
            Block = block;
        }
        
        public void Show()
        {
            Console.WriteLine($"Nickname - {Name}\nLvl - {Lvl}\nBan - {Block}");
        }

        public void Ban()
        {
            Block = true;
        }

        public void Unban()
        {
            Block = false;
        }
    }

}