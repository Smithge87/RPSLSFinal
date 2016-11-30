using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Text
    {

        public void EnterGame()
        {
            Console.WriteLine("\n\nWelcome to 'Rock, Paper, Scissors, Lizard, Spock'!");
            Console.WriteLine("\nA new twist on the classic");
            Console.WriteLine("\n\n\nPlease press 'enter' to begin");
            Console.ReadLine();
            Console.Clear();
        }
        public void GetRules()
        {
            Console.WriteLine("     RULES     ");
            Console.WriteLine("---------------");
            Console.WriteLine("\nEach player will throw one of five choices:");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, or Spock");
            Console.WriteLine("\nThe choices compare as follows:");
            Console.WriteLine("\nScissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("(and as it always has) Rock crushes Scissors)");
            Console.WriteLine("\nThe first player to win two rounds is the victor!");
            Console.WriteLine("\n Please press 'enter' to return to the main menu\n");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
