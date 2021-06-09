using System;


namespace RPSLS_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {
                Run game = new Run();
                game.run_game();
                Console.WriteLine("Would you like to play again? y/n");
                string userInput = Console.ReadLine();
                if(userInput != "y")
                {
                    playAgain = false;
                }
            }
            while (playAgain == true);
        }
    }
}
