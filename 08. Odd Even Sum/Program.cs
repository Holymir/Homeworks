using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int odd = 0;
            int even = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int left = int.Parse(Console.ReadLine());
                    even += left;
                }
                else
                {
                    int right = int.Parse(Console.ReadLine());
                    odd += right;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("yes sum = {0}", odd);
            }
            else
            {
                Console.WriteLine("no diff {0}", Math.Abs(odd - even));
            }
        }
    }
}
