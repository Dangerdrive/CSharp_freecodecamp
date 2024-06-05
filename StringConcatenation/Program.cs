using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName = "John";
            string lastName = "Doe";

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            string[] names = { "John", "Doe" };
            Console.WriteLine(string.Join(" ", names));

            Console.ReadLine();
        }
    }
}
