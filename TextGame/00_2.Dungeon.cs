using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Dungeon1 : Dungeon2
    {
        Item item = new Item();

        private bool hasSword = false;
        private int num;
        public void Dungeon1Atc()
        {
            ShowText("여기는 어디지...?(주위를 둘리번 거린다.)");
            ShowText("여기에 왜 검이...?");

            while (true)
            {
                First();
            }
        }
        private void First()
        {
            Console.WriteLine("1. 검을 줍는다. 2. 주위를 둘러본다.");
            ShowRead();
            if (num == 1)
            {
                if (hasSword == true)
                {
                    ShowSystem("이미 검을 주웠습니다.");
                }
                else
                {
                    Pickup();
                }
            }
            else if (num == 2)
            {
                Around();
            }
            else
            {
                ShowSystem("잘못 입력하였습니다.");
            }
        }
        private void Pickup()
        {
            item.Drap("검");
            hasSword = true;

            ShowSystem("1. 인벤토리 2. 주위를 둘러본다.");
            ShowRead();
            if (num == 1)
            {
                item.EquipmentCheck();
            }
            else if (num == 2)
            {
                Around();
            }
            else
            {
                ShowSystem("잘못 입력하였습니다.");
                Pickup();
            }
        }
        private void Around()
        {
            ShowSystem("이동 중...");
            ShowSystem("내려가는 계단을 발견!");
            Console.WriteLine("1. 내려간다 2. 되돌아간다 3. 인벤토리");

            ShowRead();

            if (num == 1)
            {
                Dungeon2Act();
            }
            else if (num == 2)
            {
                ShowSystem("처음에 있던 곳으로 이동 중....");
                First();
            }
            else if(num == 3)
            {
                item.EquipmentCheck();
                Around();
            }
            else if(num == 4)
            {
                // 소비 인벤토리
            }
            else if (num == 5)
            {
                // 장비창
            }
            else
            {
                ShowSystem("잘못 입력했습니다.");
                Around();
            }
        }
        private void ShowText(string text)
        {
            Console.Write(text);
            Console.ReadLine();
        }
        private void ShowSystem(string text)
        {
            Console.WriteLine($"\n[System]{text}");
        }
        private void ShowRead()
        {
            int.TryParse(Console.ReadLine(), out num);
        }     
    }
}
