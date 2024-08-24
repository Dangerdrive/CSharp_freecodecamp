using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofMultiples
{
        //Define and initialise two integers(nun, length) 
        //(7, 5) (7, 14, 21, 28, 35] 
        //Create int array with size lenght
        //loop through and insert the(loop counter x num) into the array 
        //print the final array
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int len = 5;
            int[] result = new int[len];
            int counter = 0;

            for (int i = 1; i < result.Length; i++, counter++)
                result[counter] = num * i;

            foreach (var item in result)
                Console.Write($"{item} ");

            Console.ReadLine();
        }
    }
}
