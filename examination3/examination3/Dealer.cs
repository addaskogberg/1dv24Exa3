using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Dealer : Player
    {
        private int deck;
        private int player;
        private int trashDeck;

        public int Deck
        {
            get => default(int);
            set
            {
            }
        }

        public int Player
        {
            get => default(int);
            set
            {
            }
        }

        public int TrashDeck
        {
            get => default(int);
            set
            {
            }
        }

        public void AskForNewCard()
        {
            throw new System.NotImplementedException();
        }
    }
}