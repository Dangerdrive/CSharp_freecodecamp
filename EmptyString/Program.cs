using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "";

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }

            Console.ReadLine();
        }
    }
}
