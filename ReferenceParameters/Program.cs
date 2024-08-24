using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Assign(ref num);
            Console.WriteLine(num);

            Console.ReadLine();
        }
        static void Assign(ref int num) 
        {
            num = 20;
        }
    }
}
