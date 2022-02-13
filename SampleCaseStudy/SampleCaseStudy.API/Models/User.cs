using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCaseStudy.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreateDateOfUser { get; set; }
        public string Adress { get; set; }
        public string Emaill { get; set; }
        public string PhoneNumber { get; set; }


    }
}
