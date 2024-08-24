using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            age++;

            Console.WriteLine(age);

            age = age + 1;

            Console.WriteLine(age);

            age += 1;

            Console.WriteLine(age);




            string name = "John";
            name += " is programming!";
            // name -= " is programming!"; -> this will not work
            Console.WriteLine(name);

            char letter = 'A';
            letter += 'b';
            Console.WriteLine(letter);

            int i = 0;
            Console.WriteLine(i++); // first prints i, then increments
            Console.WriteLine(i);

            Console.WriteLine(++i); // first increments i, then prints i


            Console.ReadLine();

        }
    }
}
