using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CasinoSim.Generics;

namespace CasinoSim.Static_Classes
{
    public static class Deck
    {
        public static List<Card> cards = new List<Card>();

        public static void fillDeck()
        {
            cards.Add(new Card(Card.Suit.Clubs, 2));
            cards.Add(new Card(Card.Suit.Clubs, 3));
            cards.Add(new Card(Card.Suit.Clubs, 4));
            cards.Add(new Card(Card.Suit.Clubs, 5));
            cards.Add(new Card(Card.Suit.Clubs, 6));
            cards.Add(new Card(Card.Suit.Clubs, 7));
            cards.Add(new Card(Card.Suit.Clubs, 8));
            cards.Add(new Card(Card.Suit.Clubs, 9));
            cards.Add(new Card(Card.Suit.Clubs, 10));
            cards.Add(new Card(Card.Suit.Clubs, 11));
            cards.Add(new Card(Card.Suit.Clubs, 12));
            cards.Add(new Card(Card.Suit.Clubs, 13));
            cards.Add(new Card(Card.Suit.Clubs, 14));
            cards.Add(new Card(Card.Suit.Hearts, 2));
            cards.Add(new Card(Card.Suit.Hearts, 3));
            cards.Add(new Card(Card.Suit.Hearts, 4));
            cards.Add(new Card(Card.Suit.Hearts, 5));
            cards.Add(new Card(Card.Suit.Hearts, 6));
            cards.Add(new Card(Card.Suit.Hearts, 7));
            cards.Add(new Card(Card.Suit.Hearts, 8));
            cards.Add(new Card(Card.Suit.Hearts, 9));
            cards.Add(new Card(Card.Suit.Hearts, 10));
            cards.Add(new Card(Card.Suit.Hearts, 11));
            cards.Add(new Card(Card.Suit.Hearts, 12));
            cards.Add(new Card(Card.Suit.Hearts, 13));
            cards.Add(new Card(Card.Suit.Hearts, 14));
            cards.Add(new Card(Card.Suit.Diamonds, 2));
            cards.Add(new Card(Card.Suit.Diamonds, 3));
            cards.Add(new Card(Card.Suit.Diamonds, 4));
            cards.Add(new Card(Card.Suit.Diamonds, 5));
            cards.Add(new Card(Card.Suit.Diamonds, 6));
            cards.Add(new Card(Card.Suit.Diamonds, 7));
            cards.Add(new Card(Card.Suit.Diamonds, 8));
            cards.Add(new Card(Card.Suit.Diamonds, 9));
            cards.Add(new Card(Card.Suit.Diamonds, 10));
            cards.Add(new Card(Card.Suit.Diamonds, 11));
            cards.Add(new Card(Card.Suit.Diamonds, 12));
            cards.Add(new Card(Card.Suit.Diamonds, 13));
            cards.Add(new Card(Card.Suit.Diamonds, 14));
            cards.Add(new Card(Card.Suit.Spades, 2));
            cards.Add(new Card(Card.Suit.Spades, 3));
            cards.Add(new Card(Card.Suit.Spades, 4));
            cards.Add(new Card(Card.Suit.Spades, 5));
            cards.Add(new Card(Card.Suit.Spades, 6));
            cards.Add(new Card(Card.Suit.Spades, 7));
            cards.Add(new Card(Card.Suit.Spades, 8));
            cards.Add(new Card(Card.Suit.Spades, 9));
            cards.Add(new Card(Card.Suit.Spades, 10));
            cards.Add(new Card(Card.Suit.Spades, 11));
            cards.Add(new Card(Card.Suit.Spades, 12));
            cards.Add(new Card(Card.Suit.Spades, 13));
            cards.Add(new Card(Card.Suit.Spades, 14));

            shuffle();
        }

        public static void shuffle()
        {
            if(cards.Count == 0)
            {
                fillDeck();
            }

            cards = cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static Card draw()
        {
            if(cards.Count == 0)
            {
                fillDeck();
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
