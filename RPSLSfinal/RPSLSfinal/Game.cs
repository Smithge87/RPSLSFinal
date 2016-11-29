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

        public void StartGame()
        {
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("The game is called 'Rock, Paper, Scissors, Lizard, Spock");
            GetRules();
            ChooseNumberOfPlayers();
            ThrowAChoice();
            CompareChoices();
        }
        public void GetRules()
        {
            Console.WriteLine("Each player will input a choice, first player to win two rounds is victor!");
        }
        public void ChooseNumberOfPlayers()
        {
            Console.WriteLine("Please select 1 or 2 players");
            string playerAmount = Console.ReadLine();
            if (playerAmount == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (playerAmount == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again");
                ChooseNumberOfPlayers();
            }
        }
        public void ThrowAChoice()
        {
            playerOne.MakeThrow();
            playerTwo.MakeThrow();
        }
        public void CompareChoices()
        {

            if (5 + playerOne.choice - playerTwo.choice % 5 == 0)
            {
                Console.WriteLine("It was a tie!");
            }
            else if (5 + playerOne.choice - playerTwo.choice % 5 == 1)
            {
                Console.WriteLine("Player One wins!");
                playerOne.score++;
            }
            else if (5 + playerOne.choice - playerTwo.choice % 5 == 3)
            {
                Console.WriteLine("Player One wins!");
                playerOne.score++;
            }
            else if (5 + playerOne.choice - playerTwo.choice % 5 == 4)
            {
                Console.WriteLine("Player Two wins!");
                playerTwo.score++;
            }
            else if (5 + playerOne.choice - playerTwo.choice % 5 == 2)
            {
                Console.WriteLine("Player Two wins!");
                playerTwo.score++;
            }
        }
    }
}
