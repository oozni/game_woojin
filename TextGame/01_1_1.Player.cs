using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class _02_1 : Player
    {
        Player player;

        public override void LvUp()
        {
            if(player.exe >= player.maxExe)
            {
                player.lv += 1;
                player.exe -= player.maxExe;
            }
        }

        public override void Crit()
        {
            if (true)
            {
                player.crit += 1;
                // critProbability 5% 상승
            }
        }

        public override double AggressiveStr()
        {
            //strength = 10 + 장비공격력;
            double attack = strength * 1.5f * 2;
            return attack;
        }

    }
}
