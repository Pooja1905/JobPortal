using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace JobPortal.Api.Controllers
{
    [RoutePrefix("account")]
    public class AccountController : ApiController
    {
        public List<int> Accounts
        {
            get
            {
                return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            }
            set{

            }
        }

        [Route("{userId}")]
        [HttpGet]
        public IHttpActionResult GetUser(int userId)
        {
            return null;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult AddAccount(int accountInfo)
        {
            Accounts.Add(accountInfo);
            return Ok(accountInfo);
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult UpdateAccount(int newAccountId)
        {
            return Ok();
        }

        [Route("{accountId}")]
        [HttpDelete]
        public IHttpActionResult DeleteAccount(int accountId)
        {
            return Ok();
        }


    }
}