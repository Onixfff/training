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
            int userInput;
            CreateCards createCards = new CreateCards();
            Desk desk = new Desk();
            Player player = new Player();
            desk.AddCards((List<Card>)createCards.GetCards());
            Console.WriteLine($"Кард в колоде осталось - {desk.Count()}\nСколько кард вытянуть из колоды?");

            if(int.TryParse(Console.ReadLine(), out userInput))
            {
                if(desk.Count() >= userInput)
                    player.AddCards(desk.GetCards(userInput));
                else
                    Console.WriteLine("Столько карт в колоде нету");
            }

            Console.WriteLine("Ваши карты");
            player.ShowCards();
            Console.ReadKey();
        }
    }

    class Player
    {
        private List<Card> _cards = new List<Card>();

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void AddCards(List<Card> card)
        {
            _cards.AddRange(card);
        }

        public void ShowCards()
        {
            foreach (Card card in _cards)
            {
                card.ShowStats();
            }
        }

    }

    class CreateCards
    {
        private Random _random = new Random();
        private List<Card> _cards = new List<Card>();
        private string[] _cardNames = new string[31] { "Onella", "Meronalde", "Engoaaaaaa", "Zicarsoni", "Xiadne", "Waiti",
            "Xolandiso", "Uarthurst", "Rahma", "Kordenz", "Goodysiaha", "Darylic","Wriggyan", "Vivann", "Ontaitle",
            "Hanthuonga", "Piscill", "Gertineenad", "Yxaaa", "Marghus", "Nyuaaaaaaa", "Joranchornt", "Ghtoneyah",
            "Onacoba", "Pedricia", "Ynleynard", "Tedriah", "Wiloha", "Nazand", "Shama", "Ximonar"};

        public CreateCards(int minArmor = 0, int maxArmor = 6, 
            int minDamage = 1, int maxDamage = 10, int minHealth = 8, int maxHealth = 15)
        {
            for (int i = 0; i <= 30; i++)
            {
                int health = _random.Next(minHealth, maxHealth);
                int armor = _random.Next(minArmor, maxArmor);
                int damage = _random.Next(minDamage, maxDamage);
                Card card = new Card(_cardNames[i], health, armor, damage);
                _cards.Add(card);
            }
        }

        public object GetCards()
        {
            return _cards;
        }
    }

    class Desk
    {
        private List<Card> _cards = new List<Card>();

        public int Count()
        {
            return _cards.Count();
        }

        public void ShowCards()
        {
            foreach(Card card in _cards)
            {
                card.ShowStats();
            }
        }

        public void AddCards(List<Card> cards)
        {
            _cards.AddRange(cards);
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void DeleteCard(Card card)
        {
            _cards.Remove(card);
        }

        public Card GetCard()
        {
            return _cards.First();
        }

        public List<Card> GetCards(int userInput)
        {
            int index = 0;
            return _cards.GetRange(index, userInput);
        }
    }

    class Card
    {
        public string name { get; private set; }
        public int damage { get; private set; }
        private int _health;
        private int _armor;

        public Card(string name,int health, int armor, int damage)
        {
            this.name = name;
            _health = health;
            _armor = armor;
            this.damage = damage;
        }

        public void AcceptDamag(int damage)
        {
            if(damage > _armor)
                _health = _health - (damage - _armor);
        }

        public void Treatment(int healing)
        {
            _health += healing;
        }

        public void TakingArmor(int armor)
        {
            _armor += armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name Card - {name} HP - {_health} Damage - {damage} Armor - {_armor}");
        }
    }
}
