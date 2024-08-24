using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "John Doe";
            var phoneNumber = "555-555-5555";
            var age = 25;

            Console.WriteLine("His name is ");
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("He is ");
            Console.WriteLine(age);
            Console.WriteLine();
            Console.WriteLine("His number is ");
            Console.WriteLine(phoneNumber);
            Console.WriteLine();
            
                Console.ReadLine();
        }
    }
}
