using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i += 2;
            }

            do
            { 
                Console.WriteLine("do while: " + i);
                i++;
            } 
            while (i <= 13);
                        Console.ReadLine();
        }
    }
}
