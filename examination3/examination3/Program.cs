using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examination3
{
    class Program
    {   // initierar spelet
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BlackjackManager blackjackmanager = new BlackjackManager();
            blackjackmanager.StartGame();
        }
    }
}
