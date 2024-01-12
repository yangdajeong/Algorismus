using System;
using System.Collections.Generic;
using System.Drawing;

namespace LinkedList
{
    internal class test1
    {
        static void Main1(string[] args)
        {
            LinkedList<int> ints = new LinkedList<int>();

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요!");

                int num = int.Parse(Console.ReadLine());

                if (num > 0) //양수
                {

                    ints.AddLast(num);

                }
                else if (num < 0) //음수
                {
                    ints.AddFirst(num);
                }
                else
                {
                    Console.WriteLine("0은 제외! 다시 입력하세요!");
                }


                foreach (int element in ints)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }
        }
    }
}
