using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            if (maxNum == (sum - maxNum))
            {
                Console.WriteLine("yes sum = {0}", maxNum);
            }
            else
            {
                Console.WriteLine("no diff = {0}", Math.Abs(sum - maxNum - maxNum));
            }
        }
    }
}
