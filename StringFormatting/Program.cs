using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 25;

            Console.WriteLine("His name is " + name + " and he is " + age + " years old. \n");
            Console.WriteLine("His name is {0} and he is {1} years old. \n", name, age);

            Console.ReadLine();
        }
    }
}
