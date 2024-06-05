using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //condition ? true : false

            string result = age >= 0 ? "Valid Age" : "Invalid Age";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
