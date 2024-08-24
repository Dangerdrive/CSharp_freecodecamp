using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTableExercise
{
    internal class Program
    {
        /*
         * Ask the user for a number for the table
         * Write a for loop to print X times table
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(number + " x " + i + " = " + number * i);
                //Console.WriteLine($"{number} x {i} = {number * i}");
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }

            Console.ReadLine();
        }
    }
}
