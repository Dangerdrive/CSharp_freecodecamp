using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, z = 30;
                        
            int age = 35;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = 123456789L; // L is used to make it process as 64bit number (32b int is default)
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -123.456D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 123.456F; // F is used to make it process as 32bit number (64b double is default)
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 123.456M; // M is used to make it process as 128bit number (64b double is default)
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();
        }
    }
}
