using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_classes_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(200,20,43);
            player1.ShowStats();
        }
    }

    class Player
    {
        public int Health;
        public int Damage;
        public int Mana;

        public Player(int health, int damage, int mana)
        {
            if (health < 0)
                Health = 100;
            else
                Health = health;

            if (damage < 0)
                Damage = 100;
            else
                Damage = damage;

            if (mana < 0)
                Mana = 100;
            else
                Mana = mana;
        }

        public void ShowStats()
        {
            Console.WriteLine($"HP - {Health}\nDamage - {Damage}\nMana - {Mana}");
            Console.ReadKey();
        }
    }
}
