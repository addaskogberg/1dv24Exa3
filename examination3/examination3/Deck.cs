using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private List<Card> trashDeck = new List<Card>();
        private string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "Q", "K" };
        // Unicode for Spades, Clubs, Hearts and Diamonds
        private Char[] suits = { '\u2660', '\u2663', '\u2665', '\u2666' };

        public List<Card> Cards { get => cards; set => cards = value; }
        public List<Card> TrashDeck { get => cards; set => cards = value; }

        public Deck(bool dealerDeck)
        {
            if (dealerDeck)
            {
                InitiateDeck();
            }
            ShuffelDeck();
    
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(GetNextCard());
            }
        }

        public void InitiateDeck()
        {
            foreach(Char suit in suits)
            {
                foreach (string face in faces)
                {
                    Cards.Add(new Card(suit, face));
                    // Console.WriteLine(suit + face);
                }
            }
        }
        // https://stackoverflow.com/questions/25943286/fisher-yates-shuffle-on-a-cards-list/25943363#25943363

        public void ShuffelDeck()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public void MoveToTrashDeck()
        {
            throw new System.NotImplementedException();
        }

        public void FillDeck()
        {
            throw new System.NotImplementedException();
        }

        public Card GetNextCard()
        {
            if (cards.Count < 1)
            {
                FillDeck();
            }
            Card c = cards[0];
           // Console.WriteLine(c);
            cards.RemoveAt(0);
            return c;
        }
    }
}