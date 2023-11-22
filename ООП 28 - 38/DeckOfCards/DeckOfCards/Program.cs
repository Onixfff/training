using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DeckOfCards
{
    class Program
    {
        private static Deck MainCardDeck = new Deck(new CreateMain().CreateStartCards());

        private static List<Player> players = new List<Player>()
            {
                new Player("Player1", new List<Card>()),
                new Player("Player2", new List<Card>())
            };

        private static int player = 0;

        private static int maxPlayers;

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int menuIndex = 0;

            if (players.Count > 0)
            {
                player = 0;
                maxPlayers = players.Count;
                MainCardDeck.Shuffles();

                while (true)
                {
                    bool result = false;

                    while (!result)
                    {
                        Console.WriteLine($"Игрок - {players[player]._nickName}" +
                        $"\nВаши возможности:" +
                        $"\n1.Добавить карту" +
                        $"\n2.Показать карты" +
                        $"\n3.Закончить ход");

                        string userInput = Console.ReadLine().ToString();
                        result = int.TryParse(userInput, out menuIndex);
                        Console.Clear();
                    }

                    menu = (Menu)menuIndex - 1;

                    switch (menu)
                    {
                        case Menu.addCard:
                            AddCard();
                            break;
                        case Menu.ShowCard:
                            ShowCards();
                            break;
                        case Menu.End:
                            End();
                            break;
                        default:
                            Console.WriteLine("Такого пунка меню нету");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Должен быть хотябы 1 игрок");
            }
        }

        private static void AddCard()
        {
            Console.Clear();
            Card card = MainCardDeck.GetFirstCard();
            players[player].AddCard(card);
            MainCardDeck.DeliteCard(card);
            if (card == null)
                Console.WriteLine("Карт в колоде больше нету");
        }

        private static void ShowCards() 
        {
            Console.Clear();
            players[player].ShowCards();
            Console.WriteLine();
        }

        private static void End()
        {
            Console.Clear();
            player++;

            if (player >= maxPlayers)
            {
                player = 0;
            }
        }
    }

    public enum Menu
    {
        addCard,
        ShowCard,
        End
    }

    public class Player
    {
        public readonly string _nickName;
        private List<Card> _cards;

        public Player(string nickName, List<Card> cards)
        {
            _nickName = nickName;
            this._cards = cards;
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
            List<Card> cards = _cards.ToList();
            _cards = cards;
        }

        public void ShowCards()
        {
            Console.WriteLine($"Карты игрока - {_nickName}:");
            foreach (var card in _cards)
            {
                card.Show();
            }
        }
    }

    public class Deck
    {
        private List<Card> _cards = new List<Card>();

        public Deck(List<Card> cards)
        {
            this._cards = cards;
        }

        public void DeliteCard(Card card)
        {
            if (_cards.Count > 0)
                _cards.Remove(card);
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public List<Card> GetCards()
        {
            return _cards;
        }

        public void ShowCards()
        {
            if (_cards.Count > 0)
            {
                foreach (var card in _cards)
                {
                    card.Show();
                }
            }
            else
            {
                Console.WriteLine("Карт нету");
            }
        }

        public void Shuffles()
        {
            Random random = new Random();

            for (int i = _cards.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = _cards[j];
                _cards[j] = _cards[i];
                _cards[i] = temp;
            }
        }

        public Card GetFirstCard()
        {
            if (_cards.Count != 0)
                return _cards[0];
            else
                return null;
        }
    }

    public class CreateMain
    {
        public List<Card> CreateStartCards()
        {
            List<Card> cards = new List<Card>();
            int countRangs = Rang.rang.Count;
            int maxCardSuit = Suit.suit.Count;
            string cardSuit = Suit.suit[0];

            for(int i = 0; i < countRangs ; i++)
            {
                for (int j = 0; j < maxCardSuit; j++)
                {
                    cards.Add(new Card(Suit.suit[j], Rang.rang[i]));
                }
            }

            if(cards != null && cards.Count > 0)
                return cards;
            else
                return null;
        }
    }

    public class Card
    {
        private string _suit;
        private string _rang;

        public Card(string suit, string rang)
        {
            _suit = suit;
            _rang = rang;
        }

        public void Show()
        {
            Console.WriteLine($"{_rang}{_suit}");
        }

    }

    public static class Rang
    {
        public static readonly List<string> rang = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
    }

    public static class Suit
    {
        public static readonly List<string> suit = new List<string> { "♠", "♣", "♦", "♥" };
    }
}
