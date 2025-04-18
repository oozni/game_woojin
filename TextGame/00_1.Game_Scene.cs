using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class GameLogin : Dungeon1
    {
        public void Login()
        { 
            while (true)
            {
                Console.WriteLine("- 엔터를 눌러 계속 진행 하세요 -");
                Console.WriteLine("게임을 시작하겠습니까? 1. Yes  2. No");
                int.TryParse(Console.ReadLine(), out int num);

                if (num == 1)
                {
                    Dungeon1Atc();
                    break;
                }
                else if (num == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("잘못 입력하였습니다.");
                    continue;

                }
            }
        }
    }
}
