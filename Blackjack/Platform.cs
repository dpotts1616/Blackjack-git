using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Platform
    {
        //member variables
        List<Players> table;
        Deck deck;

        //constructor
        public Platform()
        {

        }

        //methods
        public void RunBlackjack()
        {
            deck = new Deck();
        }
    }
}
