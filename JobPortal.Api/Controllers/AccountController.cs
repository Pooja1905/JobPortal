using JobPortal.Api.Controllers.Base;
using JobPortal.Business;
using JobPortal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace JobPortal.Api.Controllers
{
    [RoutePrefix("account")]
    public class AccountController : BaseApiController<AccountBusiness>
    {
        [Route("{userId}")]
        [HttpGet]
        public IHttpActionResult GetUser(int userId)
        {
            return Ok(Business.GetUser(userId));
        }

        [Route("AddUser")]
        [HttpPost]
        public IHttpActionResult AddAccount(User user)
        {
            Business.AddUser(user);
            return Ok(user.UserId);
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult UpdateAccount(User user)
        {
            Business.UpdateUser(user);
            return Ok(user.UserId);
        }

        [Route("AuthorizeUser")]
        [HttpPost]
        public IHttpActionResult AuthorizeUser([FromBody]LoginModel model)
        {
            int userId = -1;
            try
            {
                userId = Business.GetUser(model.EmailAddress, model.Password);
            }
            catch(Exception ex)
            {
                return  Ok(-1);
            }
            return Ok(userId);
        }

        [Route("{userId}")]
        [HttpDelete]
        public IHttpActionResult DeleteAccount(int userId)
        {
            Business.DeleteUser(userId);
            return Ok();
        }
    }

    public class LoginModel
    {
        public String EmailAddress { get; set; }
        public String Password { get; set; }
    }
}