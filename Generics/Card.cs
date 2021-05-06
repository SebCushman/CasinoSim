using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim.Generics
{
    public class Card
    {
        public enum Suit
        {
            Clubs,
            Hearts,
            Diamonds,
            Spades
        }

        public Suit suit;
        public int value;

        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
