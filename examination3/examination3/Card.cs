using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Card
    {
        private string suit; 
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

        public String Suit
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

        public Card(String suit, string face)
        {
            Suit = suit;
            Face = face;
        }
    }
}