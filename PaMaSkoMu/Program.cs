using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputPlayer;
        //string inputCPU;
        int randomInt;

        bool playAgain = true;

        while (playAgain)
        {
            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                Console.WriteLine("Choose between ROCK. PAPER and SCISSORS:   ");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                // palyer input check
                if (inputPlayer == "ROCK" || inputPlayer == "PAPER" || inputPlayer == "SCISSORS")
                {
                    //Random computer choice + palyer input outcome
                    switch (randomInt)
                    {
                        case 1:
                            //inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");

                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            //inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");

                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            //inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");

                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                
                Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }
                else
                {
                    Console.WriteLine("Invalid entry!");
                    Console.Write("Please enter a valid entry:   ");
                }
            }

            if (scorePlayer == 3)
            {
                Console.WriteLine("Player WON!");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("CPU WON!");
            }
            else
            {

            }

            Console.WriteLine("Do you want to play again?(y/n)");
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
            else
            {

            }
        }
    }
}