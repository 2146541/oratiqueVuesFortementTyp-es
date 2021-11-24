using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oratiqueVuesFortementTypées.Models
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public String email { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, int age, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }
    }
}
