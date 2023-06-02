using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string playerInput, cpuInput;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {
                int playerScore = 0;
                int cpuScore = 0;

                while (playerScore < 3 && cpuScore < 3)
                {
                    Console.Write("Chose between: ROCK, PAPER, SCISSORS: \n\n");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            cpuInput = "ROCK";
                            Console.WriteLine("Computer chose ROCK\n\n");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Its a Draw\n\n");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("Computer Wins\n\n");
                                cpuScore++;
                            }
                            break;

                        case 2:
                            cpuInput = "PAPER";
                            Console.WriteLine("Computer chose PAPER\n\n");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Computer Win\n\n");
                                cpuScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Its a Draw!\n\n");

                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                playerScore++;
                            }
                            break;

                        case 3:
                            cpuInput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS\n\n");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("Computer Wins!\n\n");
                                cpuScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("Its a Draw\n\n");

                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Entry");
                            break;

                    }

                    Console.WriteLine("SCORES:\tPlayer: {0}\tComputer: {1}\n", playerScore, cpuScore);
                }

                Console.WriteLine("Do you want to play again?\nType 'y' for yes, 'n' for no");
                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
               else if (loop == "n")
                {
                    playAgain = false;
                }
            }


        }
        
    }
}
