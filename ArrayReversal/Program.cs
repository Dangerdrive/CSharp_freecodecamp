using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[]
                {
                    1, 2, 3, 4, 5, 6
                };
            Array.Reverse(num);

            foreach (var item in num) 
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
