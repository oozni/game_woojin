using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Dungeon2
    {
        public void Dungeon2Act()
        {
            ShowSystem("- 지하 2층 - ");
        }
        private void ShowText(string text)
        {
            Console.Write(text);
            Console.ReadLine();
        }
        private void ShowSystem(string text)
        {
            Console.WriteLine($"\n(System){text}");
        }
    }

}
