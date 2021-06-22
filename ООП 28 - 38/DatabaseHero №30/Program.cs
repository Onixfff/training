using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHero
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            Console.SetCursorPosition(50, 0);
            Console.WriteLine("База данных игроков");
            Console.SetCursorPosition(0, 0);
            while (true) {
                Console.Write("\nМеню:\n1 - показать всех игроков\n2 - добавить игрока\n3 - заблокировать игрока\n4 - разблокировать игрока\n5 - удалить игрока\n--------------\nВведите:");
                string userInput = Console.ReadLine();
                int menu;
                bool check = int.TryParse(userInput, out menu);
                if (check == true)
                {
                    switch (menu)
                    {
                        case 1:
                            database.ShowPlayers();
                            break;
                        case 2:
                            check = false;
                            while(check == false)
                            {
                                Console.Write("Введите ник игрока: ");
                                string nik = Console.ReadLine();
                                Console.Write("Введите лвл игрока: ");
                                userInput = Console.ReadLine();
                                int lvl;
                                check = int.TryParse(userInput, out lvl);
                                if (check == true)
                                {
                                    Console.WriteLine($"nik - {nik}, lvl - {lvl}");
                                    database.AddPlayer(nik, lvl);
                                }
                                else
                                {
                                    Console.WriteLine($"Неправельно набран lvl - {userInput}");
                                }
                            }
                            break;
                        case 3:
                            bool checkId = false;
                            while(checkId == false)
                            {
                                Console.Write("Введите id игрока: ");
                                userInput = Console.ReadLine();
                                int id;
                                checkId = int.TryParse(userInput, out id);
                                if(checkId == true)
                                {
                                    check = database.CheckPlayer(id);
                                    if(check == true)
                                    {
                                        database.BanPlayer(id);
                                    }
                                }
                            }
                            break;
                        case 4:
                            checkId = false;
                            while (checkId == false)
                            {
                                Console.Write("Введите id игрока: ");
                                userInput = Console.ReadLine();
                                int id;
                                checkId = int.TryParse(userInput, out id);
                                if (checkId == true)
                                {
                                    check = database.CheckPlayer(id);
                                    if (check == true)
                                    {
                                        database.UnbanPlayer(id);
                                    }
                                }
                            }
                            break;
                        case 5:
                            database.DelitePlayer();
                            break;
                        default:
                            Console.WriteLine("Такого пункта меню нету");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Такого пункта меню нету");
                }
                Console.ReadKey();
            }
        }
    }

    class Database
    {
        private List<Player> players = new List<Player>() { new Player("Антон", 21), new Player("Женя", 55) };

        public void BanPlayer(int id)
        {
            foreach (var player in players)
            {
                player.BanPlayer(id);
            }
        }

        public void UnbanPlayer(int id)
        {
            foreach (var player in players)
            {
                player.Unban(id);
            }
        }

        public void AddPlayer(string name, int lvl)
        {
            players.Add(new Player(name, lvl));
        }

        public void ShowPlayers()
        {
            foreach (var player in players)
            {
                player.ShowPlayer();
            }
        }

        public void DelitePlayer()
        {
            bool checkInt = false;
            while (checkInt == false)
            {
                Console.Write("\nВведите id элемента: ");
                string userInput = Console.ReadLine();
                int userId;
                checkInt = int.TryParse(userInput, out userId);
                if (checkInt == true)
                {
                    bool check = CheckPlayer(userId);
                    if(check == true)
                    {
                        players.RemoveRange(userId - 1, 1);
                        Console.WriteLine("Игрок удалён из базы данных");
                    }
                    else
                    {
                        Console.WriteLine("Такого id нету");
                    }
                }
            }
        }

        public bool CheckPlayer(int id)
        {
            bool check = false;
            foreach (var player in players)
            {
                check = player.CheckPlayer(id);
                if(check == true)
                {
                    return check;
                }
            }
            return check;
        }
    }

    class Player
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Lvl { get; private set; }
        public bool Ban { get; private set; }
        private static int _lastId;

        public Player(string name, int lvl)
        {
            _lastId++;
            Id = _lastId;
            Name = name;
            Lvl = lvl;
            Ban = false;
        }

        public void BanPlayer(int id)
        {
            if(Id == id)
            {
                Ban = true;
            }
        }

        public void Unban(int id)
        {
            if(Id == id)
            {
                Ban = false;
            }
        }

        public void ShowPlayer()
        {
            Console.WriteLine($"id - {Id}\nname - {Name}\nlvl - {Lvl}\nban - {Ban}\n---------------\n");
        }

        public bool CheckPlayer(int id)
        {
            bool check = false;
            if(Id == id)
            {
                check = true;
            }
            return check;
        }
    }
}
