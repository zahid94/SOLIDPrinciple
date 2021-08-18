using SOLIDPrinciple.Models;
using SOLIDPrinciple.Service.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.SRP
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private readonly UserService service;
        public UserController()
        {
            service = new UserService();
        }

        [HttpPost]
        [Route("Create")]
        // POST api/<controller>
        public IHttpActionResult Create(Users users)
        {
            if (ModelState.IsValid)
            {
                service.AddUsers(users);
                return Content(HttpStatusCode.Created, "User added.");
            }
            else
            {
                return Content(HttpStatusCode.NotAcceptable, "Requirement is not fullfull.");
            }
        }
    }
}