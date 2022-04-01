using System;
using System.Collections.Generic;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GamePlay currplay;

            Console.WriteLine("火柴游戏");
            List<GamePlay> gameplays = new List<GamePlay>();

            for (int i = 1; i <=2; i++)
            {
                GamePlay gp = new GamePlay() { Name = $"玩家{i}" };
                gameplays.Add(gp);
            }
            currplay = gameplays[0];


            //Console.WriteLine("游戏开始");

            while (true)
            {
                Console.WriteLine("当前火柴状态");
                Console.WriteLine(GameMatchRecor.GameState());
                Console.WriteLine($"现在是第{GameMatchRecor.GameCount}回合，请{currplay.Name}请输入Row_Count");

                var row_count = Console.ReadLine();
                int row = 0;
                int count = 0;
                string msg = "";
                var row_count_split = row_count.Split('_');

                if (int.TryParse(row_count_split[0], out row) && int.TryParse(row_count_split[1], out count))
                {
                    if (!currplay.Action(row, count, out msg)) 
                    {
                        Console.WriteLine(msg);
                    }

                    if (GameMatchRecor.IsEnd())
                    {
                        Console.WriteLine($"游戏结束");
                        Console.WriteLine("游戏小计");
                        foreach (var item in GameMatchRecor.GameMsg)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"很遗憾{ currplay.Name}输了 请再接再厉");
                        Console.WriteLine("扣1234再可再来一局，否则结束游戏");
                        var IsRes = Console.ReadLine();
                        if (IsRes == "1234")
                        {
                            GameMatchRecor.ReSet();
                            continue;
                        }
                        else { 
                            break; 
                        }                   
                    }
                }
                else 
                {
                    Console.WriteLine("请输入正确的格式Row_Count");
                    continue;
                }     

                if (currplay == gameplays[0])
                {
                    currplay = gameplays[1];
                }
                else
                {
                    currplay = gameplays[0];
                }
                GameMatchRecor.GameCount += 1;

            }

         



        }
    }
}
