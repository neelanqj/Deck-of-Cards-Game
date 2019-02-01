using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards.models
{
    public class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            Reset();
        }

        public Card Deal(){
            Card topCard = cards.First();

            cards.Remove(topCard);

            return topCard;
        }

        public void Reset() {    
            Random rnd = new Random();

            Card[] cardDeck = new Card[52];

            // Creates the cards.
            for(int a = 1; a<=13;a++) { // Card value
                for(int b = 1;b<=4;b++) { // Suit value
                    cardDeck[a*b] = new Card(b,a);
                }
            }

            cards = cardDeck.OrderBy(x => rnd.Next()).ToList();
        }

        public void Shuffle() {
            Random rnd = new Random();

            // Shuffle the cards
            cards = cards.OrderBy(x => rnd.Next()).ToList();
        }
    }
}