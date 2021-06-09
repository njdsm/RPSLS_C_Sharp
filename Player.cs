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
        public List<string> gestures;

        //constructor
        public Player()
        {
            this.wins = 0;
            this.choice = "";
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
        }

        //member methods

    }
}
