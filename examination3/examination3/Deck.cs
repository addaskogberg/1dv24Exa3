using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "Q", "K" };
        private string[] suits = { "Clubs", "Hearts", "Diamonds", "Spades" };

        public List<Card> Cards { get => cards; set => cards = value; }

        public Deck(bool dealerDeck)
        {
            if (dealerDeck)
            {
                InitiateDeck();
            }
        }

        public void InitiateDeck()
        {
            foreach(string suit in suits)
            {
                foreach (string face in faces)
                {
                    Cards.Add(new Card(suit, face));
                    // Console.WriteLine(suit + face);
                }
            }
        }

        public void ShuffelDeck()
        {
            throw new System.NotImplementedException();
        }

        public void MoveToTrashDeck()
        {
            throw new System.NotImplementedException();
        }

        public void FillDeck()
        {
            throw new System.NotImplementedException();
        }
    }
}