using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string firstName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return this.FirstName + ' ' + this.LastName + ' ' + this.PhoneNumber;
        }
    }

  
}