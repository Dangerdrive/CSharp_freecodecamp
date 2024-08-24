using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "John";
            int ageInput = 30;
            string adressInput = "67 Wisard St.";

            PrintDetails(age:ageInput,
                         address:adressInput,
                         name:nameInput);

            Console.ReadLine();
        }
        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name} \nAge: {age} \nAddress: {address}");
        }
    }
}
