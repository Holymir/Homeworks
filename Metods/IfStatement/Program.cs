using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }

        static void PrintSign(int n = 3)
        {
            if (n < 0)
            {
                Console.WriteLine("{0} is Negative!", n);
            }
            else if (n > 0)
            {
                Console.WriteLine("{0} is positive!", n);
            }
            else
            {
                Console.WriteLine("{0} is zero!", n);
            }

        }
    }
}
