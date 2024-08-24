
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                234, 23, 534, 5, 0, 77
            };

            Console.WriteLine("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            search = Array.IndexOf(numbers, search);

            Console.WriteLine($"Index: {search}");

            Console.ReadLine();
        }
    }
}
