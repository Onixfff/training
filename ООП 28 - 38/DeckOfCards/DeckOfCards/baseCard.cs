using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    abstract class baseCard
    {
        public string name { get; private set; }
        public int health { get; private set; }
        public int armor { get; private set; }
        public int damage { get; private set; }
        public int picture { get; private set; }
    }
}
