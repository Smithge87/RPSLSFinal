using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Player
    {
        public string nameOne;
        public string nameTwo;
        public int choice;
        public int score = 0;
        public virtual int MakeThrow()
        {
            Console.WriteLine("this will hopefully be overwritten and not matter");
            return 1;      
        }


    }
}
