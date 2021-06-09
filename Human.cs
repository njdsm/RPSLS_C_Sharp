using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_C_Sharp
{
    class Human : Player
    {
        //member variables
        public string name;
        //constructor
        public Human(string name)
        {
            this.name = name;
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
            return "making choice as human";
        }
    }
}
