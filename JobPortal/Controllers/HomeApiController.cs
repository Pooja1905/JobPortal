using JobPortal.DAL;
using JobPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobPortal.Controllers
{
    public class HomeApiController : ApiController
    {
        [HttpPost]
        public User AuthorizeUser(User userDetails)
        {
            var user = new UserContext().Users.FirstOrDefault(x => x.EmailAddress == userDetails.EmailAddress && x.Password == userDetails.Password);
            if (user != null)
            {
                return new User 
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    EmailAddress = user.EmailAddress
                };
            }
            else
            {
                return new User();
            }
        }

        [HttpPost]
        public User RegisterUser(User userDetails)
        {
            var context = new UserContext();
            var user = context.Users.FirstOrDefault(x => x.EmailAddress == userDetails.EmailAddress);
            if (user != null && user.UserId > 0 )
            {
                return new User();
            }
            else
            {
                context.Users.Add(userDetails);
                context.SaveChanges();
                user = context.Users.FirstOrDefault(x => x.EmailAddress == userDetails.EmailAddress);
                return new User
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    EmailAddress = user.EmailAddress
                };
            }
        }

    }
}
