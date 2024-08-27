using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_functions
{
    internal class Program
    {
        public class Person
        {
            public string Name;
            public int Age;

            //constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetail()
            {
                return $"Name: {Name}\nAge: {Age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Johnny", 27);
            //Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}");
            Console.WriteLine(person.ReturnDetail());

            Console.ReadLine();
        }
        //static string ReturnDetail(string name, int age)
        //{

        //   return $"Name: {name}\nAge: {age}";
        //}}


        //static string ReturnDetail(Person person)
        //        {
        //    return $"Name: {person.Name}\nAge: {person.Age}";
        //}
    }
}