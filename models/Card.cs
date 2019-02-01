namespace DeckOfCards.models
{
    public class Card
    {
        public string stringVal { get; set; }
        public string suit { get; set; }
        public int val { get; set; }

        public Card(int isuit, int ival)
        {
            if(val == 1) stringVal = "Ace";
            else if(val == 11 ) stringVal = "Jack";
            else if(val == 12 ) stringVal = "Queen";
            else if(val == 13 ) stringVal = "King";
            else stringVal = ival.ToString();

            if(isuit == 1) suit = "Clubs";
            else if (isuit==2) suit = "Spades";
            else if (isuit == 3) suit = "Hearts";
            else suit = "Diamonds";
        }
    }
}