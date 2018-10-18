using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp.NewDb
{

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return this.FirstName + ' ' + this.LastName + ' ' + this.PhoneNumber;
        }
    }

  
}