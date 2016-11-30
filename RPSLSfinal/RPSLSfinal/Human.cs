using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Human : Player
    {
        
        public override int MakeThrow()
        {
            Console.WriteLine("\n\nPlease enter either rock, paper, scissors, lizard, or spock");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice == "rock")
            {
                choice = 0;
            }
            else if (userChoice == "paper")
            {
                choice = 1;
            }
            else if (userChoice == "scissors")
            {
                choice = 2;
            }
            else if (userChoice == "spock")
            {
                choice = 3;
            }
            else if (userChoice == "lizard")
            {
                choice = 4;
            }
            else
            {
                Console.WriteLine("Please make another choice");
                MakeThrow();
            }
            return choice;
            
        }
    }
}
