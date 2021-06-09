using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_C_Sharp
{
    class Run
    {
        //Member Variables
        public int round = 0;

        //Constructor
        public Run()
        {
            Human PlayerOne = new Human("Player One");
            Computer PlayerTwo = new Computer();
        }

        //Member Methods
        public void Run_game()
        {
            Console.WriteLine("Game is Running!");
            bool multiplayer = this.Multiplayer();
            int rounds_to_win = this.Rounds();

        }

        public bool Multiplayer()
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
                return this.Multiplayer();
            }
        }

        public int Rounds()
        {
            try
            {
                Console.WriteLine("Enter a number for how many rounds to win\n:");
                int number = Int32.Parse(Console.ReadLine());
                if (number < 2)
                {
                    Console.WriteLine("Pick a number greater than 2 please.");
                    return this.Rounds();
                }
                return number;
            }
            catch
            {
                Console.WriteLine("Need a number.");
                return this.Rounds();
            }
        }
    }
}
