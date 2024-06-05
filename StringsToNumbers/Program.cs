using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsToNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge  = "-23";
            int age         = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textPrice = "23.45"; //varies between cultures
            decimal price = Convert.ToDecimal(textPrice);
            Console.WriteLine(price);

            string textPrice2 = "23.45"; //varies between cultures
            decimal price2 = Convert.ToDecimal(textPrice2, CultureInfo.InvariantCulture); //InvariantCulture is a class that represents the culture of the current thread
            Console.WriteLine(price2);

            Console.ReadLine();
        }
    }
}
