using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public interface IDamageble
    {
        void TakeDamage();
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
    public class Character
    {

    }
}
