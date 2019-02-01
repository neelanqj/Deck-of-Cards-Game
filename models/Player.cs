using System.Collections.Generic;

namespace DeckOfCards.models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> hand { get; set; }

        public Card Draw(Deck deck) {

            Card card = deck.Deal();
            hand.Add(card);

            return card;
        }

        public Card Discard(int idx){
            Card card = hand[idx];
            hand.RemoveAt(idx);

            return card;
        }
    }
}