using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //System.FormatException - non numeric
            //System.OverflowException - int overflow

            try
            {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
            catch (Exception) //any exception. It needs to be the last case.
            {
                Console.WriteLine("Something has went wrong");
            }


            Console.ReadLine();

        }
    }
}
