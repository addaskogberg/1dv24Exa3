using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Card
    {
        private char suit; 
        private string face;

        public string Face
        {
            get
            {
                return this.face;
            }
            private set
            {
                this.face = value;
            }
        }

        public Char Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }
        }

        public Card(Char suit, string face)
        {
            Suit = suit;
            Face = face;
        }

        public override string ToString()
        {
            return Face + Suit;
        }
    }
}