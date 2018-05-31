using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Dealer : Player
    {
        private Deck dealerDeck;
       
     

        public Dealer(string name)
            : base(name, 15)
        {
            dealerDeck = new Deck(true);
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

        // hämtar nytt kort
        public Card AskForNewCard()
        {
            return dealerDeck.GetNextCard();
        }
        // kastar dealers kort i skräphögen
        public void AddTrashCard(Card card)
        {
            dealerDeck.MoveToTrashDeck(card);
        }
    }
}