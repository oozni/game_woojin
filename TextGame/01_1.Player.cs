using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal abstract class Player : IDamageble
    {
        private string name;
        enum Status
        {
            str = 1,
            def = 2,
            cri = 3
        }
        public int lv = 1;
        public int exe = 0;
        public int maxExe = 100;

        public int hp;
        public int mp;

        public int strength = 10;
        public int defense = 10;
        public int crit = 0;

        private int critProbability = 0;
        public void TakeDamage()
        {
            double damage =  AggressiveStr();
            Console.WriteLine($"플레이어가 {damage}의 피해를 입었습니다.");
        }

        public abstract void LvUp();
        public abstract void Crit();
        public abstract double AggressiveStr();
    }
}
// 데미지 = 공격력 × (기준값 ÷ (기준값 + 방어력))

//기본 공격력: 50  
//장비 보너스: +20  
//스킬 배율: 1.5 (150%)  
//크리티컬: x2(치명타 발생)
//랜덤값: 1.05 (105% 보정)

//총합 = (50 + 20) × 1.5 × 2 × 1.05
// = 70 × 1.5 = 105
// = 105 × 2 = 210
// = 210 × 1.05 = 220.5 → 최종 데미지 약 221