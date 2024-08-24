using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            //if (message == compare)
            if (message.Equals(compare)) //best practice
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");
            }

            Console.ReadLine();
        }
    }
}
