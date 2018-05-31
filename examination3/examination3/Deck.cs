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
        // Unicode för Spader, klöver, hjärta and ruter
        private Char[] suits = { '\u2660', '\u2663', '\u2665', '\u2666' };

        public List<Card> Cards { get => cards; set => cards = value; }
        public List<Card> TrashDeck { get => cards; set => cards = value; }

        // startar metoden för skapa kortlek och blanda kortlek
        public Deck(bool dealerDeck)
        {
            if (dealerDeck)
            {
                InitiateDeck();
            }
            ShuffelDeck();
        }

        //skapar kortlek
        public void InitiateDeck()
        {
            foreach(Char suit in suits)
            {
                foreach (string face in faces)
                {
                    Cards.Add(new Card(suit, face));
                }
            }
        }

        // Fisher yates 
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

        //kasta kort i skräphögen
        public void MoveToTrashDeck(Card card)
        {
            trashDeck.Add(card);
        }

        public void FillDeck()
        {
            foreach(Card card in trashDeck)
            {
                cards.Add(card);
            }
            trashDeck = new List<Card>();
        }

        // dra nytt kort så länge det finns kort i kortleken. Fyller kortleken från skräphögen.
        public Card GetNextCard()
        {
            if (cards.Count < 1)
            {
                Console.WriteLine("System: Shuffling cards from trash and adding them to deck!");
                FillDeck();
                ShuffelDeck();
            }
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }
}