using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            int total = num1 + num2 + num3;

            int[] numbers = new int[6];
            //            numbers[0] = 5;
            //            numbers[1] = 10;
            //            numbers[2] = 15;

//            Console.Write("Enter a number: ");
//            numbers[0] = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter a number: ");
//            numbers[1] = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter a number: ");
//            numbers[2] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine($"{numbers[i]}");
            }

            Console.ReadLine();
        }
    }
}
