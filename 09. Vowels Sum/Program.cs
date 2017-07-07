using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (currentChar == 'a')
                {
                    sum++;
                }
                else if (currentChar == 'e')
                {
                    sum += 2;
                }
                else if (currentChar == 'i')
                {
                    sum += 3;
                }
                else if (currentChar == 'o')
                {
                    sum += 4;
                }
                else if (currentChar == 'u')
                {
                    sum += 5;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
