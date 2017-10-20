using NETStandard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETStandard.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService ps = new PersonService();
            var personList = ps.GetPersons();

            foreach (var person in personList)
            {
                System.Console.WriteLine($"{person.Name}, {person.Age} years old, from {person.City}");
            }

            System.Console.ReadLine();
        }
    }
}
