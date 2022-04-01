using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public  interface GameAction
    {
        public bool Action(int Row, int Count,out string actiommsg);
    }
}
