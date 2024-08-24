using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5));

            Console.ReadLine();
        }
        static int Add(int a, int b) 
        {
            return a + b;
        }
    }
}
