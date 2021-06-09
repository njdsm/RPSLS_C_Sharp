using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_C_Sharp
{
    class Player
    {
        //member variables
        public int wins;
        public string choice;
        public string[] gestures = new string[5];

        //constructor
        public Player()
        {
            gestures[0] = "rock";
            gestures[1] = "paper";
            gestures[2] = "scissors";
            gestures[3] = "lizard";
            gestures[4] = "spock";
        }

        //member methods
    }
}
