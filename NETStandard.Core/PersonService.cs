using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETStandard.Core
{
    public class PersonService
    {
        public List<Person> PersonList { get; set; }

        public PersonService()
        {
            PersonList = new List<Person>()
            {
                new Person()
                {
                    Name = "Bryan",
                    Age = 22,
                    City = "Malabon"
                },
                new Person()
                {
                    Name = "Alvine",
                    Age = 22,
                    City = "Taguig"
                },
                new Person()
                {
                    Name = "Philip",
                    Age = 23,
                    City = "Makati"
                }

            };
        }

        public List<Person> GetPersons()
        {
            return PersonList;
        }

        public List<Person> GetPersonsByName(string name)
        {
            return PersonList.Where(p => p.Name.Contains(name)).ToList();
        }
    }
}
