using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        /* 
         * Ask user to enter password, and store 
         * Ask user to enter password again, and store 
         * Check if they are both contain something 
         * If so check if they are the same 
         * If they are, print "Passwords match" 
         * If they are not, print "Passwords do not match" 
         * If they are empty, print "Please enter a password." 
         */
        static void Main(string[] args)
        {
            Console.Write("Enter password ");
            string pass1 = Console.ReadLine();

            Console.Write("Re-enter password ");
            string pass2 = Console.ReadLine();

            if (!string.IsNullOrEmpty(pass1) && !string.IsNullOrEmpty(pass2))
            {
                if (pass1.Equals(pass2))
                {
                    Console.WriteLine("Passwords match.");
                }
                else
                {
                    Console.WriteLine("Passwords do not match.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            Console.ReadLine();
        }
    }
}
