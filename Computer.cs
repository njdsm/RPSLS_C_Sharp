using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_C_Sharp
{
    class Computer : Player
    {
        //member variables
        public string name;
        //constructor
        public Computer()
        {
            this.name = "Player Two";
            this.wins = 0;
            this.choice = "";
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
        }
        //member methods
        public string Make_choice()
        {
            return "making choice";
        }

    }
}
