using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class GameMatchRecor
    {
        public static List<List<int>> Line = new List<List<int>>();
        public static int GameCount = 1;
        public static List<string> GameMsg = new List<string>();
        //初始化
        public GameMatchRecor()
        {
            if (Line.Count < 1)
            {
                //行1
                Line.Add(new List<int>() { 1, 2, 3 });
                //行2
                Line.Add(new List<int>() { 1, 2, 3, 4, 5 });
                //行3
                Line.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 7 });
            }

            
        }

        //重置
        public static void ReSet() 
        {
            Line.Clear();
            GameMatchRecor newgame = new GameMatchRecor();
            GameCount = 1;
            GameMsg.Clear();
        }

        public static string GameState()
        {
            string res = "";

            foreach (var item in Line)
            {
                foreach (var itemlist in item)
                {
                    res += "*";
                }
                res += "\n";
            }
            return res;
        
        }

        public static bool IsEnd() 
        {
            return Line.All(f => f.Count == 0);
        }
    }
}
