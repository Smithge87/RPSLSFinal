using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Game : Text
    {
        Player playerOne;
        Player playerTwo;
        
        public void StartGame()
        {
            EnterGame();
            GetRules();
            ChooseNumberOfPlayers();
            DeclareVictor();
            SupposeReplay();
        }
        public void GetRules()
        {
            Console.WriteLine("\n\nEach player will input a choice, first player to win two rounds is victor!");
        }

        public void ChooseNumberOfPlayers()
        {
            Console.WriteLine("Please select 1 or 2 players");
            string playerAmount = Console.ReadLine();
            if (playerAmount == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
                RunRoundsOnePlayer();
            }
            else if (playerAmount == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
                RunRoundsTwoPlayer();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again");
                ChooseNumberOfPlayers();
            }
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
                Console.WriteLine("\nPlayer Two:");
                playerTwo.MakeThrow();
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
