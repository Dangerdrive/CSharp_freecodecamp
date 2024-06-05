using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadLine();
        }
    }
}
