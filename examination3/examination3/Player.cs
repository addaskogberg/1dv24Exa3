using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class Player
    {
        private int maxCardSum;
        private String name;

        public Player(string name)
        {
            this.Name = name;
        }

        public int MaxCardSum
        {
            get => default(int);
            set
            {
            }
        }

        public string Name { get => name; set => name = value; }

        public void IsBusted()
        {
            throw new System.NotImplementedException();
        }

        public void EmptiesHand()
        {
            throw new System.NotImplementedException();
        }

        public void HasFiveCards()
        {
            throw new System.NotImplementedException();
        }

        public void FullHand()
        {
            throw new System.NotImplementedException();
        }
    }
}