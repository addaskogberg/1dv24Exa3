using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Card
    {
        private CardSuits suit; 
        private string face;

        public string Face
        {
            get => default(string);
            private set
            {
                this.face = value;
            }
        }

        public CardSuits Suit
        {
            get => default(CardSuits);
            set
            {
                this.suit = value;
            }
        }

        public Card(CardSuits suit, string face)
        {
            Suit = suit;
            Face = face;
        }
    }
}