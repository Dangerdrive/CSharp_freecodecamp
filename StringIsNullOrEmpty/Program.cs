using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");


            //method 1
            if (name != "")
                Console.WriteLine("0");
            //method 2
            if (!name.Equals("")) // this would not work if name == "null"
                Console.WriteLine("1");
            //method 3
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("2");
            }
            Console.ReadLine();
        }
    }
}
