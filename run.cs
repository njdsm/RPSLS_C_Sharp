using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_C_Sharp
{
    class Run
    {
        //Member Variables
        //public class playerOne;
        //computer = new Computer();
        public int round = 0;

        //Constructor
        public Run()
        {
            Console.WriteLine("Hello");
        }

        //Member Methods
        public void run_game()
        {
            Console.WriteLine("Game is Running!");
            bool multiplayer = this.multiplayer();
            Console.WriteLine(multiplayer);
        }

        public bool multiplayer()
        {
            Console.WriteLine(@"play against computer or play locally against a friend
                                (must provide your own friend)\n
                                1: Singleplayer\n
                                2: Multiplayer\n:");
            string user_input = Console.ReadLine();
            if (user_input == "1")
            {
                return false;
            }
            else if (user_input == "2")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Pick 1 or 2");
                return this.multiplayer();
            }
        }

    }
}
