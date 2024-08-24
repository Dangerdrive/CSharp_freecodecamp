using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[]
                {
                    1, 2, 3, 4, 5, 6
                };

            //Array.Clear(num, 0, num.Length);
            Array.Clear(num, 3, 2);

            foreach (int i in num) 
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
