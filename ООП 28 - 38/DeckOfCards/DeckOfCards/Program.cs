using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck MainCardDeck = new CardDeck(new CreateMainCards().CreateStartCarts());
            
            List<Player> players = new List<Player>()
            {
                new Player(new CardDeck(new List<Card>()), "Player1"),
                new Player(new CardDeck(new List<Card>()), "Player2")
            };

            Menu menu = new Menu();

            int player;
            int maxPlayers;
            if (players.Count > 0)
            {
                player = 0;
                maxPlayers = players.Count;
                while (true)
                {
                    Console.WriteLine($"Игрок - {players[player]._nickName}" +
                        $"\nВаши возможности:" +
                        $"\n1.Добавить карту" +
                        $"\n2.Показать карты" +
                        $"\n3.Закончить ход");

                    string userInput = Console.ReadLine().ToString();
                    menu = (Menu)(Convert.ToInt32(userInput) - 1);

                    switch (menu)
                    {
                        case Menu.addCard:
                            Console.Clear();
                            Card card = MainCardDeck.GetRandomCard();
                            
                            if (card == null)
                            {
                                Console.WriteLine("Карт в колоде больше нету");
                            }
                            else
                            {
                                players[player].AddCard(card);
                                MainCardDeck.DeliteCard(card);
                            }
                            break;
                        case Menu.ShowCard:
                            Console.Clear();
                            players[player].ShowCards();
                            Console.WriteLine();
                            break;
                        case Menu.End:
                            Console.Clear();
                            player++;
                            if (player >= maxPlayers)
                            {
                                player = 0;
                            }
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
        private CardDeck _cardDeck;

        public Player(CardDeck cardDeck, string nickName)
        {
            _nickName = nickName;
            _cardDeck = cardDeck;
        }

        public void AddCard(Card card)
        {
            _cardDeck.AddCard(card);
        }

        public void ShowCards()
        {
            Console.WriteLine($"Карты игрока - {_nickName}:");
            _cardDeck.ShowCards();
        }
    }

    public class CardDeck
    {
        private List<Card> _cards = new List<Card>();

        public CardDeck(List<Card> cards)
        {
            this._cards = cards;
        }

        public void DeliteCard(Card card)
        {
            if(_cards.Count > 0)
                _cards.Remove(card);
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void ShowCards()
        {
            if (_cards.Count > 0)
            {
                foreach (var card in _cards)
                {
                    card.ShowCard();
                }
            }
            else
            {
                Console.WriteLine("Карт нету");
            }
        }

        public int ShowCountCards() => _cards.Count;

        public Card GetRandomCard()
        {
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = _cards.Count;
            if (_cards.Count <= 0)
                return null;
            Card card = _cards[random.Next(minRandom, maxRandom)];

            if (card != null)
            {
                return card;
            }
            else
            {
                Console.WriteLine("В колоде больше нету карт");
                return null;
            }
        }
    }

    public class CreateMainCards
    {
        public List<Card> CreateStartCarts()
        {
            List<Card> cards = new List<Card>();
            int maxCardsRang = (int)CardRang.Ace;
            int maxCardSuit = (int)CardSuit.spades;
            CardSuit cardSuit = CardSuit.clubs;

            for(int i = 0; i <= maxCardsRang ; i++)
            {
                for (int j = 0; j <= maxCardSuit; j++)
                {
                    cards.Add(new Card(cardSuit, (CardRang)i));

                    switch (cardSuit)
                    {
                        case CardSuit.clubs:
                            cardSuit = CardSuit.diamonds;
                            break;
                        case CardSuit.diamonds:

                            cardSuit = CardSuit.hearts;
                            break;
                        case CardSuit.hearts:

                            cardSuit = CardSuit.spades;
                            break;
                        case CardSuit.spades:

                            cardSuit = CardSuit.clubs;
                            break;
                    }
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
        private CardSuit cardSuit;
        private CardRang cardRang;

        public Card(CardSuit CardSuit, CardRang CardRang)
        {
            cardSuit = CardSuit;
            cardRang = CardRang;
        }

        public void ShowCard()
        {
            Console.WriteLine($"Масть - {cardSuit} ---  Ранг - {cardRang}");
        }

    }

    public enum CardSuit
    {
        clubs, // Трефы 
        diamonds, // Бубны 
        hearts, // Червы 
        spades // Пики 
    }

    public enum CardRang
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        nine,
        ten,
        Jack,
        Lady,
        King,
        Ace
    }
}
