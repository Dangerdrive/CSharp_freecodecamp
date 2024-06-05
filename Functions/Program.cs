using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public static void something()
        {
            Console.WriteLine();
        }
    }

    class Test2
    {
        public void something2()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.something();
            //if not static function
            Test2 test = new Test2();
            test.something2();

            WelcomeMessage();

            Console.ReadLine();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome!");
        }
    }
}
