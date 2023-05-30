using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            while (true)
            {
                Console.WriteLine("\nSelect your move (rock, paper, scissors) or type 'quit' to end the game:");
                string playerMove = Console.ReadLine().ToLower();

                if (playerMove == "quit")
                    break;

                string computerMove = GetComputerMove();
                Console.WriteLine("Computer chose: " + computerMove);

                string result = DetermineWinner(playerMove, computerMove);

                if (result == "win")
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                }
                else if (result == "lose")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine("Player Score: " + playerScore);
                Console.WriteLine("Computer Score: " + computerScore);
            }

            Console.WriteLine("\nFinal Scores:");
            Console.WriteLine("Player Score: " + playerScore);
            Console.WriteLine("Computer Score: " + computerScore);
            Console.WriteLine("Thank you for playing!");

            Console.ReadLine();
        }

        static string DetermineWinner(string playerMove, string computerMove)
        {
            if (playerMove == computerMove)
                return "tie";

            if (playerMove == "rock")
            {
                if (computerMove == "scissors")
                {
                    return "win";
                }
                else
                {
                    return "lose";
                }
            }

            if (playerMove == "paper")
            {
                if (computerMove == "rock")
                {
                    return "win";
                }
                else
                {
                    return "lose";
                }
            }
            if (playerMove == "scissors")
            {
                if (computerMove == "paper")
                {
                    return "win";
                }
                else
                {
                    return "lose";
                }
            }

            return "invalid";
        }

        static string GetComputerMove()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 3);

            switch (randomNumber)
            {
                case 0:
                    return "rock";
                case 1:
                    return "paper";
                default:
                    return "scissors";
            }
        }
    }
}