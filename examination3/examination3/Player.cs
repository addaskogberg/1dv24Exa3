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

        // spelarkonstruktor
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
       
        //referens till handen som kontrollerar om spelaren är tjock
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
        // referens till handen som kontrollerar om det finns fem kort
        public bool HasFiveCards()
        {
            return Hand.HasFiveCards();
        }

    }
}