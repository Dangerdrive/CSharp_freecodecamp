using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;

            // vat = 10; error -> vat is a constant and cannot be changed

            int balance = 1000;

            Console.WriteLine(balance + (balance * vat / 100D));
            Console.WriteLine(balance + (balance * percentVAT));

            Console.WriteLine(vat);
            Console.ReadLine();
        }
    }
}
