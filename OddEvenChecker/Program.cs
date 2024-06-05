using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var num1 = 10;
            var num2 = 3;
            var remainder = num1 % num2;

            Console.WriteLine(remainder);

            num1 = 14;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
