using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// highlighted stuff is what is actually being used to run the program

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //could be System.Console.WriteLine("Hello World!"); if System was not imported
            Console.ReadLine();
        }
    }
}
