using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        //struct Person
        //    {
        //    public string Name;
        //    public int Age;

        //    //constructor
        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}

        class Person
        {
            public string Name;
            public int Age;

            //constructor
            public Person()
            { }
            public Person(string name)
            {
                Name = name;
                Age = -1;
                }
            public Person(int age)
            {
                Age = age;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            //it is possible to create multiple constructors using classes

        }
        static void Main(string[] args)
        {
            //Person person = new Person("Johnny", 27)
            Person person = new Person(27);

            if (!string.IsNullOrEmpty(person.Name))
            {
                Console.WriteLine("Name: " + person.Name);
            }
            if (person.Age > -1)
            {
                Console.WriteLine($"Age: {person.Age}");
            }

            Console.ReadLine();
        }
    }
}
