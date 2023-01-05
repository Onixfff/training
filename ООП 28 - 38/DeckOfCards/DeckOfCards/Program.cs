using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    enum Suit
    {
        Trump, //(Козырь)
        Diamonds, //(Бубы / Алмазы)
        Hearts, //(Черви / Сердца)
        Clubs, //(Трефы / Клубы)
        Spades, //(Пики / Лопаты)
    }

    enum Rank
    {
        Ace, // (Туз)
        Jack, // (Валет / Джек)
        Queen,// (Дама / Королева(
        King,// (Король)
        Joker,// (Джокер)
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Desk
    {

    }

    class Card
    {
        public Suit suit { get; private set; }
        public Rank rank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            this.rank = rank;
            this.suit = suit;


        }
    }
}
