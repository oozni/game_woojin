using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Item : ItemList
    {
        ItemList ItemList = new ItemList();

        private List<string> equipment = new List<string>();
        private int count = 0;
        public void Equipment(string item)
        {
            equipment.Add(item);
            count++;
        }
        public void EquipmentCheck()
        {
            List<Weapon> key = ItemList.itemData.Keys.ToList();

            if (count <= 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (string num in equipment)
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.Write($"{i}번[{num}]이(가) 있습니다.\n");
                    }
                }
            }
            Console.WriteLine("상세 정보를 확인 하시겠습니까?");
            Console.WriteLine("1. Yes 2. No");
            int.TryParse(Console.ReadLine(), out int input);

            if (input == 1)
            {
                Console.WriteLine("목록의 번호를 선택해 주세요");
                int.TryParse(Console.ReadLine(), out int input1);


                //Console.WriteLine(equipment[input1]);
                //Console.WriteLine($"{key[input]}{key.}");
            }
        }
        public void Drap(string item)
        {
            Equipment(item);
            Console.WriteLine($"[System] {item}을(를) 획득하였습니다.");
        }
        public void Remove(string item)
        {
            equipment.Remove(item);
            count--;
        }
        // 장작
        // 해제
    }
}
