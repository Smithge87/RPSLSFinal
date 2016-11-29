using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Player
    {
        public int choice;
        public int score;
        public virtual int MakeThrow()
        {
            Console.WriteLine("this will hopefully be overwritten and not even matter");
            return 1;      
        }


    }
}
