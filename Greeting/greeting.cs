using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class greeting
    {
        static void Main(string[] args)
        {
            string furstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {furstName} {lastName}.\r\nYou are {age} years old.");
           
        }
    }
}
