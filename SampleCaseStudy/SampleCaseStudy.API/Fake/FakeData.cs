using Bogus;
using SampleCaseStudy.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCaseStudy.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int numberFakeUser)
        {
            if (_users == null)
            {
             _users = new Faker<User>()
             .RuleFor(u => u.Id, f => f.IndexFaker + 1)
             .RuleFor(u => u.FirstName, f => f.Name.FirstName())
             .RuleFor(u => u.LastName, f => f.Name.LastName())
             .RuleFor(u => u.DateOfBirth, f => f.Date.Past())
             .RuleFor(u => u.CreateDateOfUser, f => f.Date.Past())
             .RuleFor(u => u.Adress, f => f.Address.FullAddress())
             .RuleFor(u => u.Emaill, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
             .RuleFor(u => u.PhoneNumber, f => f.Person.Phone)
             .Generate(numberFakeUser);
            }
        
            return _users;
        }
    }
}
