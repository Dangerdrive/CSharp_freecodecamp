using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct Person
        {
            public string Name;
            public int Age;

            //constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            Person person;
            person.Name = "John";
            person.Age = 30;

            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine($"Age: {person.Age}");

            string newName = ReturnPerson(out int newAge);

            Console.ReadLine();
        }
        static string ReturnPerson(out int age)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            return name;

        }

//The out and ref keywords in C# are both used to pass arguments by reference to a method
/*
 * Initialization Requirement:

out: The argument passed with out does not need to be initialized before being passed to the method. The method is required to assign a value to it.
ref: The argument passed with ref must be initialized before being passed to the method. The method can modify the existing value but is not required to assign a new one.
Mandatory Assignment:

out: The method must assign a value to the out parameter before it exits.
ref: The method is not required to assign a new value to the ref parameter; it can simply modify the existing value.
Intended Use Cases:

out: Typically used when a method needs to return multiple values or when a value needs to be initialized within the method.
ref: Used when the method needs to operate on and potentially modify an existing value provided by the caller.
*/
}
}
