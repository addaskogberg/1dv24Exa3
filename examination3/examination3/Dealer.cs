using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Dealer : Player
    {
        private Deck dealerDeck;
        // private Deck trashDeck;
        private int player;
        // private string name;

        public Dealer(string name)
            : base(name, 15)
        {
            dealerDeck = new Deck(true);
            // trashDeck = new Deck(false);
        }

        public Deck DealerDeck
        {
            get => default(Deck);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
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

        public Card AskForNewCard()
        {
            return dealerDeck.GetNextCard();
        }

        public void AddTrashCard(Card card)
        {
            dealerDeck.MoveToTrashDeck(card);
        }
    }
}