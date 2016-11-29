using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    class Computer : Player
    {
        List<int> throwChoices = new List<int> {0,1,2,3,4};
        public override int MakeThrow()
        {   
            Random random = new Random();
            choice = (throwChoices[random.Next(0,5)]);
            return choice;
        }

    }
}
