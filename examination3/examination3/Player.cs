using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Player
    {
        private Hand hand;
        private int maxCardSum;
        private String name;

        public Player(string name, int maxCardSum)
        {
            this.Name = name;
            this.hand = new Hand();
            this.maxCardSum = maxCardSum;
        }

        public int MaxCardSum
        {
            get 
            {
                return maxCardSum;
            }
        }

        public string Name { get => name; set => name = value; }
        public Hand Hand { get => hand; }

        public bool IsBusted()
        {
            return Hand.IsBusted();
        }

        // skapar ny lista för att undvika att skicka referenser
        public List<Card> EmptiesHand()
        {
            List<Card> cardsToReturn = new List<Card>();
            foreach (Card card in hand.CardsInHand)
            {
                cardsToReturn.Add(card);
            }

            hand.CardsInHand = new List<Card>();
            return cardsToReturn;
        }

        public bool HasFiveCards()
        {
            return Hand.HasFiveCards();
        }

        public void FullHand()
        {
            throw new System.NotImplementedException();
        }
    }
}