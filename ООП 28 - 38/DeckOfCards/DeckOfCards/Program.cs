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
            desk.AddCard(createCards.GetCards());
            Console.WriteLine($"Кард в колоде осталось - {desk.Count()}\nСколько кард вытянуть из колоды?");
            if(int.TryParse(Console.ReadLine(), out userInput))
            {
                if(desk.Count() >= userInput)
                    player.AddCard(desk.GetCard(userInput));
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

        public void AddCard(List<Card> card)
        {
            _cards.AddRange(card);
        }

        public void ShowCards()
        {
            foreach (Card card in _cards)
            {
                card.ShowCard();
            }
        }

    }

    class CreateCards
    {
        private List<Card> cards = new List<Card>();
        private int _maxArmor = 6;
        private int _minArmor = 0;
        private int _maxDamage = 10;
        private int _minDamage = 1;
        private int _maxHealth = 15;
        private int _minHealth = 8;
        string[] cardNames = new string[31] { "Onella", "Meronalde", "Engoaaaaaa", "Zicarsoni", "Xiadne", "Waiti",
            "Xolandiso", "Uarthurst", "Rahma", "Kordenz", "Goodysiaha", "Darylic","Wriggyan", "Vivann", "Ontaitle",
            "Hanthuonga", "Piscill", "Gertineenad", "Yxaaa", "Marghus", "Nyuaaaaaaa", "Joranchornt", "Ghtoneyah",
            "Onacoba", "Pedricia", "Ynleynard", "Tedriah", "Wiloha", "Nazand", "Shama", "Ximonar"};

        Random rnd = new Random();

        public CreateCards()
        {
            for (int i = 0; i <= 30; i++)
            {
                int health = rnd.Next(_minHealth, _maxHealth);
                int armor = rnd.Next(_minArmor, _maxArmor);
                int damage = rnd.Next(_minDamage, _maxDamage);
                Card card = new Card(cardNames[i], health, armor, damage);
                cards.Add(card);
            }
        }

        public List<Card> GetCards()
        {
            return cards;
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
                card.ShowCard();
            }
        }

        public void AddCard(List<Card> cards)
        {
            _cards = cards;
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

        public List<Card> GetCard(int userInput)
        {
            int index = 0;
            return _cards.GetRange(index, userInput);
        }
    }

    class Card
    {
        public string name { get; private set; }
        private int _health;
        private int _armor;
        public int damage { get; private set; }

        public Card(string name,int health, int armor, int damage)
        {
            this.name = name;
            _health = health;
            _armor = armor;
            this.damage = damage;
        }

        public void Acceptdamag(int damage)
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

        public void ShowCard()
        {
            Console.WriteLine($"Name Card - {name} HP - {_health} Damage - {damage} Armor - {_armor}");
        }
    }
}
