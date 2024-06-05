using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[]
            {
                1, 32, 3, 0, 5, 6, 22, 8, 9, 26, 11, 12, 13
            };

            //string test = "";
            //test = test.Replace("", " ");

            Array.Sort(number);

            foreach (int i in number)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
