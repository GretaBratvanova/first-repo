using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class FilledSquare
    {
        static void PrintHeaderRow(int n)
        {
            string sign = new string('-', 2 * n);
            Console.WriteLine(sign);
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderRow(n);
        }
    }
}
