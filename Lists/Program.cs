using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listnum = new List<int>()
            {
                1, 2, 3
            };

            //or
            //listnum.Add(1);
            //listnum.Add(2);
            //listnum.Add(3);

            for (int i = 3; i < 6; i++)
            {
                Console.Write("Enter a number: ");
                listnum.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listnum.Count; i++) { Console.Write($"{listnum[i]} "); }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
