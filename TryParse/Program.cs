using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine(); //example: non numeric input. It would segfault
            //int num = Convert.ToInt32(numInput); 

            bool success = int.TryParse(numInput, out int num);
            
            if (success)
            {
                Console.WriteLine("You entered: " + num);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadLine();
        }
    }
}
