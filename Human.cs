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
        }
        //member methods
        public string Make_choice()
        {
            return "making choice as human";
        }
    }
}
