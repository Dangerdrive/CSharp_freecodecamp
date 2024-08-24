using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(6);

            Console.WriteLine(result);

            PrintName("John");
            PrintName();

            Console.ReadLine();
        }

        //static int Add(int a, int b = default)
        //{ 
        //    return a + b;
        //}
        static void PrintName(string name =" Felippe" ) { Console.WriteLine($"My name is {name} "); }
        static int Add(int a, [Optional] int b)
        {
            return a + b;
        }
    }
}
