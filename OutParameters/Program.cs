using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        //out parameters are used to return multiple values from a method.
        //This feature allows a method to output values through parameters,
        //similar to how pointers might be used in C to achieve similar functionality.
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);

            Console.WriteLine(num);
            Console.ReadLine();
        }
        static void test(out int num) 
        { 
            num = 5; 
        }
    }
}
