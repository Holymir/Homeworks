using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n != 0 && k != 0)
            {
                int[] nums = new int[n];
                nums[0] = 1;
                for (int i = 1; i <= n-1; i++)
                {
                    int temp = 0;
                    for (int j = i - k; j <= i - 1; j++)
                    {
                        if (j >= 0)
                        {
                            temp += nums[j];
                        }

                    }
                    nums[i] = temp;
                }
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
