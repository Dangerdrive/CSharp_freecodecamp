using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fields
{
    public class Person
    {
        private string Name;
        private int Age;


        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //public void SetAge(int age)
        //{
        //    if (age >= 0 && age < 150)
        //    {
        //        Age = age;
        //    }
        //    else
        //    {
        //        Age = -1;
        //    }
        //}
        public void SetAge(int age) => Age = age >= 0 && age <= 150 ? age : -1;

        public int GetAge()
        {
            return Age;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Name = "invalid name";
            }

        }

        public string GetName() => Name;

        public string ReturnDetail()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Johnny", 27);
            //Console.WriteLine($"Name: {person.Name}\nAge: {person.Age}");
            Console.WriteLine(person.ReturnDetail());

            person.SetName("");
            Console.WriteLine("Your name is: " + person.GetName());

            person.SetAge(200);
            Console.WriteLine("Your age is: " + person.GetAge());


            Console.ReadLine();
        }
    }
}

