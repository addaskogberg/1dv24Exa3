using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class BlackjackManager
    {
        Deck player = new Deck();
        private int dealer;

        public int Dealer
        {
            get => default(int);
            set
            {
            }
        }

        public int Player
        {
            get => default(int);
            set
            {
            }
        }

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void PrepareNewRound()
        {
            throw new System.NotImplementedException();
        }

        public void RunGame()
        {
            throw new System.NotImplementedException();
        }
    }
}