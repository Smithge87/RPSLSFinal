using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            game.StartGame();

            Console.ReadKey();

        }
    }
}
