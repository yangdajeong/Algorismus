using System.Collections.Generic;
using System.Drawing;

namespace Algorismus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            List<int> num_list = new List<int>();

            for (int i = 0; i <= num; i++)
            {
                num_list.Add(i);
                num_list[i] = i;
            }

            //num_list.RemoveAt(0);
            for (int i = 1; i <= num; i++)
            {
                num_list[i] = i;
                Console.WriteLine(num_list[i]);
            }

        }
    }
}
