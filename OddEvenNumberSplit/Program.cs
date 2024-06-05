using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    internal class Program
    {
        /*
         * . Create two lists with integer data type, one for even numbers, one for odd .
         * Loop from 0-20 . if number is even, add to even list *
         * if number is odd, add to odd list Print even list Print odd list 
         */
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++) 
            {
                if (i % 2 == 0)
                    even.Add(i);
                else
                    odd.Add(i);
            }

            Console.WriteLine("Printing even numbers:");

            foreach (var item in even)
                Console.Write($"{item} ");

            Console.WriteLine(Environment.NewLine + "Printing odd numbers:");

            foreach (var item in odd)
                Console.Write($"{item} ");

            Console.ReadLine();
        }
    }
}
