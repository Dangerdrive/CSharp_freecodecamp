using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "John"},
                {2, "Peter"},
                {3, "Mary" }
            };

            //names.Add(4, "John");

            for (int i = 0; i < names.Count; i++) 
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach(var item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Jonas"},
                {"Chemistry", "Eddy" }
            };

            Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Chemistry", out string teacher))
                Console.WriteLine(teacher);
            Console.ReadLine();
        }
    }
}
