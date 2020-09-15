using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        //member variables
        List<Cards> deck;

        //constructor
        public Deck()
        {
            deck = new List<Cards>();
            for (int i = 0; i < 4; i++)
            {
                for (int a = 1; a < 14; a++)
                    if (i == 0)
                    {
                        deck.Add(new Cards("spades", a));
                    }
                else if (i == 1)
                    {
                        deck.Add(new Cards("clubs", a));
                    }
                else if (i == 2)
                    {
                        deck.Add(new Cards("diamonds", a));
                    }
                else if (i == 3)
                    {
                        deck.Add(new Cards("hearts", a));
                    }
            }
        }

        //methods
    }
}
