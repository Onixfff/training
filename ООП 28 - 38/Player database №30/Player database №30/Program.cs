using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Player_database__30
{
    class Program
    {
        static void Main(string[] args)
        {
            Players players = new Players();
            Error error = new Error();

            bool exit = false;
            bool e;

            string userInput;

            int id;

            while (exit == false)
            {
                Console.WriteLine("{0,10}", "Меню");
                Console.Write("1: Добавить игрока.\n2: Забанить игрока по порядковому номеру.\n3: Разбанить игрока.\n4: Удалить игрока \n5: Выход\nВыберете пункт:");
                userInput = Console.ReadLine();

                e = int.TryParse(userInput, out int item);

                if (e == true)
                {
                    switch (item)
                    {
                        case 1:
                            Console.WriteLine("Введите name");
                            userInput = Console.ReadLine();
                            
                            players.addPlayer(userInput);
                            players.ShowPlayers();
                            break;
                        case 2:
                            Fry(ref e,"Введите id игрока для бана: ", out id);
                            RRR(e, id, players, 1, error);
                            break;
                        case 3:
                            Fry(ref e, "Введите id игрока для бана: ", out id);
                            RRR(e,id,players,2,error);
                            break;
                        case 4:
                            Fry(ref e, "Введите id игрока для удаление игрока: ", out id);
                            RRR(e, id, players, 3, error);
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            error.ShowError("Скорее всего вы нажали не на ту кнопку!");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        //Поменять название
        static void RRR(bool e, int id, Players players, int process, Error error)
        {
            if (e)
            {
                players.SearchPlayerById(id, process);
                players.ShowPlayers();
            }
            else
            {
                error.ShowError("Скорее всего вы нажали не на ту кнопку!");
            }
        }
        //Поменять название
        static void Fry(ref bool e, string text, out int number)
        {
            string userInput;

            Console.WriteLine(text);
            userInput = Console.ReadLine();

            e = int.TryParse(userInput, out number);
        }
    }

    class Error
    {
        public void ShowError(string text, ConsoleColor color = ConsoleColor.Red)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine($"{text}");
            Console.ForegroundColor = defaultColor;
        }
    }

    class Players : Error
    {
        private List<Player> _players = new List<Player>();

        public void addPlayer(string name, int lvl = 1, bool ban = false)
        {
            _players.Add(new Player(name, lvl, ban));
        }
        //Поменять название
        public void SearchPlayerById (int id, int process)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (i == id)
                {
                    switch (process)
                    {
                        case 1:
                            _players[i].Ban();
                            break;
                        case 2:
                            _players[i].Unban();
                            break;
                        case 3:
                            _players.RemoveAt(id);
                            break;
                        default:
                            ShowError("Ошибка программы");
                            break;
                    }
                }
                else
                {
                    ShowError("Скорее всего вы нажали не на ту кнопку!");
                }
            }
        }

        public void ShowPlayers()
        { 
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].InfoPlayer(i);
            }
        }
    }

    class Player
    {
        public string _nickname;
        public int _lvl;
        public bool _ban;

        public Player(string nickname, int lvl = 1, bool ban = false)
        {
            _nickname = nickname;
            _lvl = lvl;
            _ban = ban;
        }

        public void InfoPlayer(int i)
        {
            Console.WriteLine($"id - {i} | nickname - {_nickname} | lvl - {_lvl} | ban - {_ban}");
        }

        public void Ban()
        {
            _ban = true;
        }

        public void Unban()
        {
            _ban = false;
        }
    }
}
