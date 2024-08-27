using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVariable_FunctionScope
{
    class Person
            {
        private string name;
        private int age;
        private string address;
        public string Address {  get; set;}

        //public string Name
        //{ 
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //        {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            Name = value;
        //        }
        //        else
        //        {
        //            Name = "invalid name";
        //        }
        //    }
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
