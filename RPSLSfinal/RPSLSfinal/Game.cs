using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Game 
    {
        Player playerOne;
        Player playerTwo;
        Text text = new Text();
        
        public void StartGame()
        {
            text.EnterGame();
            EnterMenu();
            DeclareVictor();
            SupposeReplay();
        }
        public void EnterMenu()
        {
            Console.WriteLine("          MENU");
            Console.WriteLine("------------------------");
            Console.WriteLine("\n 1) One Player Game");
            Console.WriteLine("\n 2) Two Player Game");
            Console.WriteLine("\n 3) Rules");
            Console.WriteLine("\n 4) Exit\n");
            string menuChoice = Console.ReadLine();
            Console.Clear();
            if (menuChoice == "1")
            {
                ChooseOnePlayers();
            }
            else if (menuChoice == "2")
            {
                ChooseTwoPlayers();
            }
            else if (menuChoice == "3")
            {
                text.GetRules();
                EnterMenu();
            }
            else if (menuChoice == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please choose again.");
            }
        }
        public void ChooseOnePlayers()
            {
                playerOne = new Human();
                playerTwo = new Computer();
                RunRoundsOnePlayer();
            }
        public void ChooseTwoPlayers()
            {
                playerOne = new Human();
                playerTwo = new Human();
                RunRoundsTwoPlayer();
            }

        
        public void RunRoundsOnePlayer()
        {
            while (playerTwo.score < 2 && playerOne.score < 2)
            {
                Console.WriteLine("\nPlayer One:");
                playerOne.MakeThrow();
                playerTwo.MakeThrow();
                ComputeScore();
            }

        }
        public void RunRoundsTwoPlayer()
        {
            while (playerTwo.score < 2 && playerOne.score < 2)
            {
                Console.WriteLine("\nPlayer One:");
                playerOne.MakeThrow();
                Console.Clear();
                Console.WriteLine("\nPlayer Two:");
                playerTwo.MakeThrow();
                Console.Clear();
                ComputeScore();
                
            }

        }

        public void ComputeScore()
        {
                 if ((5 + playerOne.choice - playerTwo.choice) % 5 == 0)
                {
                    Console.WriteLine("It was a tie!");
                    
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 1)
                {
                    Console.WriteLine("Player One wins!");
                    playerOne.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 3)
                {
                    Console.WriteLine("Player One wins!");
                    playerOne.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 4)
                {
                    Console.WriteLine("Player Two wins!");
                    playerTwo.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 2)
                {
                    Console.WriteLine("Player Two wins!");
                    playerTwo.score++;
                }         
        }
        public void DeclareVictor()
        {
            if (playerOne.score == 2)
            Console.WriteLine("\n\nPlayer One is the Victor!");
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("\n\nPlayer Two is the Victor!");
            }
        }
        public void SupposeReplay()
        {
            Console.WriteLine("Would you like to play again (y/n)?");
            string proposal = Console.ReadLine().ToLower();
            if (proposal == "y")
            {
                Console.Clear();
                StartGame();
            }
            else if (proposal == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Entry. Please try again");
                SupposeReplay();
            }           
        }

    }
}
