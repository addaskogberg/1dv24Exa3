using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Dealer : Player
    {
        private Deck dealerDeck;
        private Deck trashDeck;
        private int player;
        // private string name;

        public Dealer(string name)
            : base(name)
        {
            dealerDeck = new Deck(true);
            foreach(var card in dealerDeck.Cards)
            {
               // Console.WriteLine(card.Face + " " + card.Suit);
            }
            
        }

        public Deck DealerDeck
        {
            get => default(Deck);
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

        public Deck TrashDeck
        {
            get => default(Deck);
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