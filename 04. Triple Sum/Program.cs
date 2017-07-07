using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = nums.Length;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = i + 1; j < lenght; j++)
                {
                    for (int k = 0; k < lenght; k++)
                    {
                        int result = nums[k];
                        if (nums[i] + nums[j] == result)
                        {
                            Console.WriteLine($"{nums[i]} + {nums[j]} == {result}");
                        }
                    }
                }
            }
        }
    }
}
