using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 30;

            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);

            Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            Console.ReadLine(); 
        }
    }
}
