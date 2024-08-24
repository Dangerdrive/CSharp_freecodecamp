using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Title();

            Console.ReadLine();
        }

        static string Title()
        {
            return "Learning C#";
        }
    }
}
