using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"Hello there!\"";
            string filePath = "C:\\Users\\John\\Documents\\file.txt";

            Console.WriteLine(speech);
            Console.WriteLine(filePath);

            filePath = @"C:\\Users\\John\\Documents\\file.txt"; // @ symbol makes it a verbatim string literal

            Console.WriteLine(filePath);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
