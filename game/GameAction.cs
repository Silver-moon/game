using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public  interface GameAction
    {
        /// <summary>
        /// 玩家动作
        /// </summary>
        /// <param name="Row"></param>
        /// <param name="Count"></param>
        /// <param name="actiommsg"></param>
        /// <returns></returns>
        public bool Action(int Row, int Count,out string actiommsg);
    }
}
