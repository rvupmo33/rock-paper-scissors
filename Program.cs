using System;

namespace GHW_RPS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;
            
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|   Lets play Rock Paper Scissors!   |");
            Console.WriteLine("--------------------------------------");

            while (playerScore !=3 && enemyScore != 3)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"|               Player score - {playerScore} || Enemy score - {enemyScore}                 |");
                Console.WriteLine("|  Enter 'r' for rock, 'p' for paper or anything else for scissors  |");
                Console.WriteLine("---------------------------------------------------------------------");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|   Enemy choice = rock   |");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("|           Tie!          |");
                            Console.WriteLine("---------------------------");
                            break;
                        case "p":
                            Console.WriteLine("|       Player Win!       |");
                            Console.WriteLine("---------------------------");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("|        Enemy Win!       |");
                            Console.WriteLine("---------------------------");
                            enemyScore++;
                            break;
                    }
                }else if (enemyChoice == 1)
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|  Enemy choice = paper   |");
                    
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("|        Enemy Win!       |");
                            Console.WriteLine("---------------------------");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("|           Tie!          |");
                            Console.WriteLine("---------------------------");
                            break;
                        default:
                            Console.WriteLine("|       Player Win!       |");
                            Console.WriteLine("---------------------------");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("| Enemy choice = Scissors |");
                    
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("|       Player Win!       |");
                            Console.WriteLine("---------------------------");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("|        Enemy Win!       |");
                            Console.WriteLine("---------------------------");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("|           Tie!          |");
                            Console.WriteLine("---------------------------");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("|         You win!        |");
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("|        You loose!       |");
                Console.WriteLine("---------------------------");
            }
        }
        }
    }
