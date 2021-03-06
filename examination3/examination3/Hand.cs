﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Hand
    {
        private int sum;
        private int aces;
        private List<Card> cardsInHand = new List<Card>();

        // Hämtar summan om summan är större än 21 och där finns ess ändras värdet på esset
        public int Sum
        {
            get
            {
                if(sum >21 && Aces >0)
                {
                    sum -= 13;
                    Aces -= 1;
                }
                return sum;
            }
            set
            {
                this.sum = value;
            }
        }

 
        public List<Card> CardsInHand
        {
            get
            {
                return cardsInHand;
            }
            set
            {
                this.cardsInHand = value;
            }
        }

        public int Aces { get => aces; set => aces = value; }

        // översätter korten till int
        public void TranslateFaces(Card card)
        {
           if(card.Face == "A")
            {
                sum += 14;
                Aces++;
            }
            else if (card.Face == "Kn")
            {
                sum += 11;
            }
            else if (card.Face == "Q")
            {
                sum += 12;
            }
            else if (card.Face == "K")
            {
                sum += 13;
            }
            else
            {
                sum += int.Parse(card.Face);
            }
        }

        public void AddCard(Card card)
        {
            cardsInHand.Add(card);
            TranslateFaces(card);
        }
        // tittar om spelare är tjock
        public bool IsBusted()
        {
            if (sum > 21)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //tittar om spelare har 5 kort och därmed vinst
        public bool HasFiveCards()
        {
            if (cardsInHand.Count >=5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            string hand = "";
            foreach(Card card in cardsInHand)
            {
                hand += card.Face + card.Suit + " ";
            }

            return hand;
        }
    }
}