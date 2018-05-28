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


        public int Sum
        {
            get
            {
                if(sum >21 && aces >0)
                {
                    sum -= 13;
                    aces -= 1;
                }
                return sum;
            }
        }

        public void TranslateFaces(Card card)
        {
           if(card.Face == "A")
            {
                sum += 14;
                aces++;
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