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
        public override string Make_choice(int round, int opponent_wins)
        {
            Console.WriteLine(@"Round {0}\n
                                Score: {1} to {2}\n
                                {3}: Make your choice!\n
                                1: rock\n
                                2. paper\n
                                3. scissors\n
                                4. lizard\n
                                5. spock\n", round, this.wins, opponent_wins, this.name);
            string user_input = Console.ReadLine();
            if (user_input is "1" || user_input is "2" || user_input is "3" || user_input is "4" || user_input is "5")
            {
                string user_choice = this.gestures[Int32.Parse(user_input) - 1];
                return user_choice;
            }
            else
            {
                Console.WriteLine("Please pick one of the options.");
                return this.Make_choice(round, opponent_wins);
            }
        }
    }
}
