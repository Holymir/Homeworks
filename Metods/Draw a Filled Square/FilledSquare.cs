using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFullSquare(n);
        }

        private static void PrintFullSquare(int n)
        {
            PrintHeader(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }

            PrintHeader(n);
        }

        private static void PrintBody(int n)
        {
            var body = string.Empty;
            for (int i = 0; i < n-1; i++)
            {
                body += @"\/";
            }
            Console.WriteLine('-' + body + '-');
        }

        static void PrintHeader(int n)
        {
            var header = new string('-', n * 2);
            Console.WriteLine(header);
        }
    }
}
