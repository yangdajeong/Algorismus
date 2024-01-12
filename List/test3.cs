using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Algorismus
{
    public class test3
    {
        static void Main3()
        {
            List<string> inventory = new List<string>();

            bool first = true;
            if (first)
            {
                inventory.Add("3m 둔검");
                inventory.Add("분뇨가 든 요강");
                inventory.Add("사마귀 앞다리");
                inventory.Add("탈부착 근육 팔다리");
            }

            Console.WriteLine("메뉴");
            Console.WriteLine("************************");
            Console.WriteLine("아이템 얻기 1번");
            Console.WriteLine();
            Console.WriteLine("아이템 버리기 2번");
            Console.WriteLine();
            Console.WriteLine("이벤토리 확인 3번");
            Console.WriteLine("************************");
            Console.WriteLine();
            int key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:

                    break;
                case 2:
                    RemoveAt(inventory);
                    break;
                case 3:
                    
                    Inventory(inventory);
                    break;
            }


        }

        public static void Inventory(List<string> inventory)
        {
            bool first = false;
            Console.WriteLine("************************");
            Console.WriteLine("소지하고 있는 아이템");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < inventory.Count; i++)
            {

                Console.WriteLine(inventory[i]);

            }

            Console.WriteLine("************************");
            Console.WriteLine("메뉴로 돌아가기 1번");
            Console.WriteLine("************************");
            Console.WriteLine();

            int key = int.Parse(Console.ReadLine());

            if(key == 1)
            {
                Main();
            }
        }


        public static void RemoveAt(List<string> inventory)
        {
            bool first = false;
            Console.WriteLine("아이템 버리기");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < inventory.Count; i++)
            {

                Console.WriteLine(inventory[i]);

            }

            int itemkey = int.Parse(Console.ReadLine());
            inventory.RemoveAt(itemkey-1);


            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("메뉴로 돌아가기 1번");
            Console.WriteLine("************************");
            Console.WriteLine();
            if (key == 1)
            {
                Main();
            }
        }


    }
}


