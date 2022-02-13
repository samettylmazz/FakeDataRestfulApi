
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Mvc;
using SampleCaseStudy.API.Fake;
using SampleCaseStudy.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCaseStudy.API.Controllers //posstman vb. test edilebilir uyg başlatım url sini kopyalayıp sonuna /api/users denilerek test edilip get post put ve delete işlemileri yapılabilir
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase

    {

        private List<User> _users = FakeData.GetUsers(200);

        [HttpGet]
        public List<User> Get()
        {

            return _users;
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
           

            
              var user = _users.FirstOrDefault(x => x.Id == id);
               return user;
        
    

        }

     

    
        [HttpPost]
        public User Post([FromBody] User user)
        {
            var newUser = _users.FirstOrDefault(x => x.Id != user.Id);
            _users.Add(newUser);
            return user;
        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editedUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editedUser.FirstName = user.FirstName;
            editedUser.LastName = user.LastName;
            editedUser.DateOfBirth = user.DateOfBirth;
            editedUser.Adress = user.Adress;
            editedUser.Emaill = user.Emaill;
            editedUser.PhoneNumber = user.PhoneNumber;
            return user;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deletedUser= _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deletedUser);

        }
    }
}
