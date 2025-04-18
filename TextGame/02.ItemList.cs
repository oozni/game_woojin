using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TextGame
{
    enum Weapon
    {
        검 = 1,
        대검 = 2,
        단검 = 3,
        도끼 = 4,
        도 = 5,
        창 = 6,
        할버드 = 7,
        망치 = 8,
        메이스 = 9,
        활 = 10,
        석궁 = 11,
        지팡이 = 12,
        완드 = 13,
        너클 = 14,
        각반 = 15,
        방패 = 16
    }
    struct ItemInformaiont()
    {
        public int strength { get; set; }
        public int defense { get; set; }
        public int cri { get; set; }
        public int speed { get; set; }
    }
    internal class ItemList
    {
        public Dictionary<Weapon, ItemInformaiont> itemData = new Dictionary<Weapon, ItemInformaiont>();  

        public void Information()
        {
            itemData[Weapon.검] = new ItemInformaiont { strength = 10, cri = 10, speed = 10 };
        }
       
    }
}
