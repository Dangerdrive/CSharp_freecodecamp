using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine("You are " + age + " years old.");


            //if (ageInput == "25") // it is possible to compare strings with == or !=, but it is not recommended
            //{
            //    Console.WriteLine("You are 25 years old.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not 25 years old.");
            //}
            if (age < 0 || age > 100)
            {
                Console.WriteLine("Invalid age.");
            }
            else
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are an adult.");
                }
                else if (age >= 13)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are a child.");
                }
            }
            Console.ReadLine();
        }
    }
}
