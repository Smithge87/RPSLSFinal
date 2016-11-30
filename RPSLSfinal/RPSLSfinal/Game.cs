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
        Player constant = new Player();
        
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
            Console.WriteLine("\n 1) One Player Game (Player vs. Computer)");
            Console.WriteLine("\n 2) Two Player Game (Player vs. Player)");
            Console.WriteLine("\n 3) Rules");
            Console.WriteLine("\n 4) Exit\n");
            string menuChoice = Console.ReadLine();
            Console.Clear();
            if (menuChoice == "1")
            {
                SelectNameOne();
            }
            else if (menuChoice == "2")
            {
                SelectNameTwo();
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
        public void SelectNameOne()
        {
            Console.WriteLine("\nPlayer one please submit your name and press 'enter':");
            constant.nameOne = Console.ReadLine();
            Console.Clear();
            ChooseOnePlayers();
        }
        public void SelectNameTwo()
        {
            Console.WriteLine("\nPlayer one please submit your name and press 'enter'");
            constant.nameOne = Console.ReadLine();
            Console.WriteLine("\nPlayer two please submit your name and press 'enter'");
            constant.nameTwo = Console.ReadLine();
            Console.Clear();
            ChooseTwoPlayers();
        }
        
        public void RunRoundsOnePlayer()
        {
            while (playerTwo.score < 2 && playerOne.score < 2)
            {
                Console.WriteLine("\n{0} make choice:", constant.nameOne);
                playerOne.MakeThrow();
                constant.nameTwo = "Computer";
                playerTwo.MakeThrow();
                Console.Clear();
                ComputeScore();
            }

        }
        public void RunRoundsTwoPlayer()
        {
            while (playerTwo.score < 2 && playerOne.score < 2)
            {
                Console.WriteLine("\n{0}make choice:", constant.nameOne);
                playerOne.MakeThrow();
                Console.Clear();
                Console.WriteLine("\n{0} make choice:", constant.nameTwo);
                playerTwo.MakeThrow();
                Console.Clear();
                ComputeScore();
                
            }

        }

        public void ComputeScore()
        {
                 if ((5 + playerOne.choice - playerTwo.choice) % 5 == 0)
                {
                    Console.WriteLine("\nIt was a tie!\n");
                    
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 1)
                {
                    Console.WriteLine("\n{0} wins!\n", constant.nameOne);
                    playerOne.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 3)
                {
                    Console.WriteLine("\n{0} wins!\n", constant.nameOne);
                    playerOne.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 4)
                {
                    Console.WriteLine("\n{0} wins!\n", constant.nameTwo);
                    playerTwo.score++;
                }
                else if ((5 + playerOne.choice - playerTwo.choice) % 5 == 2)
                {
                    Console.WriteLine("\n{0} wins!\n", constant.nameTwo);
                    playerTwo.score++;
                }         
        }
        public void DeclareVictor()
        {
            if (playerOne.score == 2)
            Console.WriteLine("\n\n{0} is the Victor!", constant.nameOne);
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("\n\n{0} is the Victor!", constant.nameTwo);
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
