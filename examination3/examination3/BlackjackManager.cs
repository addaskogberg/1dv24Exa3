using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class BlackjackManager
    {
        List<Player> players = new List<Player>();
        Dealer dealer;

        public void StartGame()
        {
            Console.WriteLine("*** 21 ***");
            dealer = new Dealer("the Dealer");
            int numberOfPlayers = GetNumberOfPlayers();
            AddPlayers(numberOfPlayers);
            RunOnePlayerMultipleTimesOrMultiplePlayers();
            Console.Read();
        }

        private void RunOnePlayerMultipleTimesOrMultiplePlayers()
        {
            if (players.Count == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    RunGame();
                }
            }
            else
            {
                RunGame();
            }
        }

        private int GetNumberOfPlayers()
        {
            int numbers = -1;
            bool falseinput = true;
            while (falseinput)
            {
                Console.WriteLine("Please enter the number of players: ");
                String numberOfPlayers = Console.ReadLine();
                if (int.TryParse(numberOfPlayers, out numbers))
                {
                    if (numbers < 1 || numbers > 5)
                    {
                        Console.WriteLine("Please choose number of players between 1 and 5");
                    }
                    else
                    {
                        falseinput = false;
                    }
                }
            }
            return numbers;
        }

        private void AddPlayers(int numberOf)
        {
            for (int i = 1; i <= numberOf; i++)
            {
                players.Add(new Player("Ready Player #" + i, 13 + i));
            }
        }

        private void ReadPlayers()
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.Name);
            }
        }

        /**
        * prepares a new round by emptying the hands and moving the used cards
        * to the trash deck
        */
        public void PrepareNewRound()
        {
            foreach(Player player in players)
            {
                List<Card> cards = player.EmptiesHand();
                foreach(Card card in cards)
                {
                    dealer.AddTrashCard(card);
                }
                player.Hand.Sum = 0;
                player.Hand.Aces = 0;
            }
            EmptieDealerHand();
        }

        public void EmptieDealerHand()
        {
            List<Card> cards = dealer.EmptiesHand();
            foreach (Card card in cards)
            {
                dealer.AddTrashCard(card);
            }
            dealer.Hand.Sum = 0;
            dealer.Hand.Aces = 0;
        }

        public void RunGame()
        {
            foreach (Player player in players)
            {
                while (player.Hand.Sum < player.MaxCardSum)
                {
                    player.Hand.AddCard(dealer.AskForNewCard());
                }

                if (player.IsBusted())
                {
                    Console.WriteLine(player.Name + ": " + player.Hand.ToString() + " (" + player.Hand.Sum + ") Busted!" );
                }
                else
                {
                    Console.WriteLine(player.Name + ": " + player.Hand.ToString() + " (" + player.Hand.Sum + ")");
                }
                if (player.IsBusted() == false)
                {
                    while (dealer.Hand.Sum < dealer.MaxCardSum)
                    {
                        dealer.Hand.AddCard(dealer.AskForNewCard());
                    }
                    if (dealer.IsBusted())
                    {
                        Console.WriteLine(dealer.Name + "     : " + dealer.Hand.ToString() + " (" + dealer.Hand.Sum + ") Busted!");
                    }
                    else
                    {
                        Console.WriteLine(dealer.Name + "     : " + dealer.Hand.ToString() + " (" + dealer.Hand.Sum + ")");
                    }
                }
                else
                {
                    Console.WriteLine(dealer.Name + "     : -");
                }
               

                if (player.Hand.Sum >21)
                {
                    Console.WriteLine("Dealer Wins!");
                }
                else if ( dealer.Hand.Sum >21)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (player.HasFiveCards())
                {
                    Console.WriteLine("Player wins with five cards!");
                }
                else if (player.Hand.Sum > dealer.Hand.Sum)
                {
                    Console.WriteLine("Player Wins!");
                }
                else
                {
                    Console.WriteLine("Dealer Wins!");
                }
                Console.WriteLine();
                PrepareNewRound();
            }
        }
    }
}