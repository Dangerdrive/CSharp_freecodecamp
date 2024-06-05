using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringInReverse
{
    internal class Program
    {
        /*
         * Ask user to input message
         * Print in order
         * Print in reverse
         *         */

        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();
            Console.WriteLine(message);

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
            
            Console.ReadLine();

        }
    }
}
