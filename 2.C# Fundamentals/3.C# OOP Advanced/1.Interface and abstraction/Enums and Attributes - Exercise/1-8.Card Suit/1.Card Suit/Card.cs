using System;

namespace _1.Card_Suit
{
    class Card:IComparable<Card>
    {
        private CardRanks cardRank;
        private CardSuits cardSuit;
        private int cardPower;

        public Card(CardRanks cardRank, CardSuits cardSuit)
        {
            this.cardRank = cardRank;
            this.cardSuit = cardSuit;
            this.cardPower = (int) cardSuit + (int) cardRank;
        }

        public override string ToString()
        {
            return $"{this.cardRank} of {this.cardSuit}.";
        }

        public Card()
        {
            
        }
        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return cardPower.CompareTo(other.cardPower);
        }
    }
}
