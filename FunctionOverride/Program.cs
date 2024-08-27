using System;

namespace FunctionOverride
{
    class Person
    {
        //public string name { get;  set; }
        //public int age { get; set; }


        //private string address;
        //public string Address {  get; set;}

        private string name;
        private int age;
        public string Name
        {
            get => name;
            set => name = string.IsNullOrEmpty(value) ? "invalid name" : value;
        }
        public int Age
        {
            get => age;
            set => age = value >= 0 && value <= 150 ? value : -1;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public string ReturnDetails()
        {
            return $"Name: {name}\nAge: {age}";
        }


        public override string ToString()
        {
            return ReturnDetails();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            //or Person person = obj as Person;
            return this.Name == person.Name && this.Age == person.Age;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("John", 25);

            Console.WriteLine(person);

            Person test = new Person("John", 25);
            if (person.Equals(test))
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }
            //it becomes the same as:
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString();

            Console.ReadLine();
        }
    }
}
