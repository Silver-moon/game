using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class GamePlay: GameMatchRecor, GameAction
    {
        public string Name { get; set; }

        public bool Action(int Row,int Count,out string Msg)
        {
            try
            {
                if (GameMatchRecor.Line.Count < Row-1)
                {
                    throw new Exception($"请输入小于或等于{GameMatchRecor.Line.Count}的Row数");
                }
                else if (GameMatchRecor.Line.Count > Row-1 && GameMatchRecor.Line[Row-1].Count < Count)
                {
                    throw new Exception($"请输入小于或等于{GameMatchRecor.Line[Row-1].Count}的Count数");
                }

                GameMatchRecor.Line[Row-1] = GameMatchRecor.Line[Row-1].Skip(Count).ToList();            
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
                return false;
            }
            Msg = $"{Name}拿了第{Row}行的{Count}个";
            GameMatchRecor.GameMsg.Add(Msg);
            return true;
        }



    }
}
