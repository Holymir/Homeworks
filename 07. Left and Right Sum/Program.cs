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

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    int left = int.Parse(Console.ReadLine());
                    leftSum += left;
                }
                else
                {
                    int right = int.Parse(Console.ReadLine());
                    rightSum += right;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("yes sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("no diff {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
