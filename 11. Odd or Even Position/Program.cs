using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }

                else
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }//end

            Console.WriteLine("oddSum = " + oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("oddMin = No");
            }
            else
            {
                Console.WriteLine("oddMin = " + oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("oddMax = No");
            }
            else
            {
                Console.WriteLine("oddMax = " + oddMax);
            }
            //Console.WriteLine(oddMin);
            //Console.WriteLine(oddMax);
            Console.WriteLine("evenSum = " + evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("evenMin = No");
            }
            else
            {
                Console.WriteLine("evenMin = " + evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("evenMax = No");
            }
            else
            {
                Console.WriteLine("evenMax = " + evenMax);
            }
            //Console.WriteLine(evenMin);
            //Console.WriteLine(evenMax);


        }
    }
}
