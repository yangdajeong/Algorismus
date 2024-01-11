using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Algorismus
{
    public class test2
    {
        static void Main2(string[] args)
        {
            List<int> num_list = new List<int>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("숫자를 입력하세요!");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                if (num_list.Contains(num))
                {
                    num_list.Remove(num);
                }
                else
                {
                    num_list.Add(num);
                }

                for (int i = 0; i < num_list.Count; i++)
                {
                    Console.Write($"{num_list[i]} ");
                }
            }
            

        }
        /*public int FindIndex(Predicate<T> match)
        {
            int[] numbers = [1, 6, 7, 8, 3];
            if (match == null)
                throw new ArgumentNullException();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (match numbers))
                    return i;
            }
            return -1;
        }
*/
    }

}
