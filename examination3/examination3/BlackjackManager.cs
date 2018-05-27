using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination3
{
    public class BlackjackManager
    {
        List<Player> players = new List<Player>();

        public void StartGame()
        {
            Console.WriteLine("*** 21 ***");
            int numberOfPlayers = GetNumberOfPlayers();
            AddPlayers(numberOfPlayers);
            ReadPlayers();
            Console.Read();
        }

        private int GetNumberOfPlayers()
        {
            int numbers = -1;
            bool falseinput = true;
            while (falseinput)
            {
                Console.WriteLine("Please enter the number of players: ");
                String numberOfPlayers = Console.ReadLine();
                if(int.TryParse(numberOfPlayers, out numbers))
                {
                    if(numbers < 1 || numbers > 5)
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
            players.Add(new Dealer("Dealer"));

            for(int i = 1; i <= numberOf; i++)
            {
                players.Add(new Player("Player #" + i));
            }
        }

        private void ReadPlayers()
        {
            foreach(Player player in players)
            {
                Console.WriteLine(player.Name);
            }
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